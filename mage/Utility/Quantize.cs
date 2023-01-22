using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace mage
{
    public class Quantize
    {
        // fields
        public struct RGB
        {
            public int R, G, B;

            public static RGB operator +(RGB p1, RGB p2)
            {
                p1.R += p2.R;
                p1.G += p2.G;
                p1.B += p2.B;
                return p1;
            }

            public static RGB operator -(RGB p1, RGB p2)
            {
                p1.R -= p2.R;
                p1.G -= p2.G;
                p1.B -= p2.B;
                return p1;
            }

            public static RGB operator *(RGB p, int factor)
            {
                p.R = p.R * factor;
                p.G = p.G * factor;
                p.B = p.B * factor;
                return p;
            }

            public static RGB operator /(RGB p, int divisor)
            {
                p.R = p.R / divisor;
                p.G = p.G / divisor;
                p.B = p.B / divisor;
                return p;
            }

            public ushort RawVal
            {
                get { return (ushort)(R | (G << 5) | (B << 10)); }
            }
        }

        // parameters
        private int numPalettes;
        private int numColors = 15;
        private int width, height;
        private int t_width, t_height;

        private RGB[,] pixels;
        private RGB[] tileAverages;

        // output
        public int[] tileAssignments;
        public int[] pixelAssignments;
        public RGB[,] BGpalette;

        // constructor
        public Quantize(Bitmap img, int numPalettes)
        {
            // check for valid pixel format
            try
            {
                img.GetPixel(0, 0);
            }
            catch
            {
                throw new FormatException("Invalid pixel format.");
            }

            this.numPalettes = numPalettes;

            Initialize(img);
        }

        private void Initialize(Bitmap img)
        {
            // get 2D array of pixels (0-31)
            width = img.Width;
            height = img.Height;
            t_width = width / 8;
            t_height = height / 8;

            pixels = new RGB[width, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color c = img.GetPixel(x, y);
                    RGB rgb;
                    rgb.R = c.R >> 3;
                    rgb.G = c.G >> 3;
                    rgb.B = c.B >> 3;
                    pixels[x, y] = rgb;
                }
            }

            // get average color of each tile
            tileAverages = new RGB[t_width * t_height];
            int index = 0;

            for (int y = 0; y < height; y += 8)
            {
                for (int x = 0; x < width; x += 8)
                {
                    RGB total = new RGB();

                    for (int v = 0; v < 8; v++)
                    {
                        for (int u = 0; u < 8; u++)
                        {
                            total += pixels[x + u, y + v];
                        }
                    }
                    tileAverages[index++] = total / 64;
                }
            }
        }

        public void Kmeans()
        {
            tileAssignments = new int[tileAverages.Length];
            if (numPalettes > 1)
            {
                Cluster(tileAverages, tileAssignments, numPalettes);
            }

            ClusterPixels();
        }

        private void ClusterPixels()
        {
            // get counts
            int[] counts = new int[numPalettes];
            foreach (int a in tileAssignments)
            {
                counts[a]++;
            }

            pixelAssignments = new int[width * height];
            BGpalette = new RGB[numPalettes, numColors];

            // for each palette
            for (int pal = 0; pal < numPalettes; pal++)
            {
                if (counts[pal] == 0) { continue; }

                // get pixel values
                RGB[] pixelValues = new RGB[counts[pal] * 64];
                int index = 0;
                for (int t = 0; t < tileAssignments.Length; t++)
                {
                    if (tileAssignments[t] != pal) { continue; }

                    int x = (t % t_width) * 8;
                    int y = (t / t_width) * 8;

                    for (int v = 0; v < 8; v++)
                    {
                        for (int u = 0; u < 8; u++)
                        {
                            pixelValues[index++] = pixels[x + u, y + v];
                        }
                    }
                }

                int[] tempAssignments = new int[pixelValues.Length];
                RGB[] clusters = Cluster(pixelValues, tempAssignments, numColors);
                // copy clusters to palette
                for (int c = 0; c < numColors; c++)
                {
                    BGpalette[pal, c] = clusters[c];
                }

                // write pixel assignments
                index = 0;
                for (int j = 0; j < tileAssignments.Length; j++)
                {
                    if (tileAssignments[j] != pal) { continue; }

                    int p = j * 64;
                    int pEnd = p + 64;
                    while (p < pEnd)
                    {
                        pixelAssignments[p++] = tempAssignments[index++];
                    }
                }
            }
        }

        private int Dist(RGB p1, RGB p2)
        {
            int Rdiff = p1.R - p2.R;
            int Gdiff = p1.G - p2.G;
            int Bdiff = p1.B - p2.B;
            return (Rdiff * Rdiff) + (Gdiff * Gdiff) + (Bdiff * Bdiff);
        }

        private RGB[] Cluster(RGB[] input, int[] assignments, int k)
        {
            RGB[] clusters = InitClusters(input, assignments, k);

            for (int i = 0; i < 2; i++)
            {
                if (AssignClusters(clusters, input, assignments, k)) { break; }
                RecalcCenters(clusters, input, assignments, k);
            }

            return clusters;
        }

        private RGB[] InitClusters(RGB[] input, int[] assignments, int k)
        {
            Random rand = new Random();

            int Kprime = (int)(2 * k * Math.Log(k));
            RGB[] tempClusters = new RGB[Kprime];
            // chose random input for clusters
            for (int i = 0; i < Kprime; i++)
            {
                int index = rand.Next(input.Length);
                tempClusters[i] = input[index];
            }

            // run clustering once
            AssignClusters(tempClusters, input, assignments, Kprime);
            RecalcCenters(tempClusters, input, assignments, Kprime);

            // get clusters and counts
            List<RGB> clusterList = new List<RGB>(Kprime);
            List<int> countList = new List<int>(Kprime);
            foreach (RGB rgb in tempClusters)
            {
                clusterList.Add(rgb);
                countList.Add(0);
            }
            foreach (int i in assignments)
            {
                countList[i]++;
            }

            // remove clusters with few points
            int threshold = (int)(input.Length / (Math.E * Kprime));
            for (int i = Kprime - 1; i >= 0; i--)
            {
                if (countList[i] < threshold)
                {
                    clusterList.RemoveAt(i);
                    countList.RemoveAt(i);
                }
                if (clusterList.Count == k) { break; }
            }

            // select centers from remaining (find most distant)
            RGB[] clusters = new RGB[k];
            int first = rand.Next(clusterList.Count);
            clusters[0] = clusterList[first];
            clusterList.RemoveAt(first);

            for (int i = 1; i < k; i++)
            {
                RGB farthestPt = new RGB();
                int maxDist = -1;

                foreach (RGB rgb in clusterList)
                {
                    RGB closestPt = new RGB();
                    int minDist = 10000;

                    // find closest cluster
                    for (int j = 0; j < i; j++)
                    {
                        int distance = Dist(clusters[j], rgb);
                        if (distance < minDist)
                        {
                            minDist = distance;
                            closestPt = rgb;
                        }
                    }
                    if (minDist > maxDist)
                    {
                        maxDist = minDist;
                        farthestPt = closestPt;
                    }
                }
                clusters[i] = farthestPt;
                clusterList.Remove(farthestPt);
            }

            return clusters;
        }

        private bool AssignClusters(RGB[] clusters, RGB[] input, int[] assignments, int k)
        {
            int numChanges = 0;

            for (int i = 0; i < assignments.Length; i++)
            {
                int closestCluster = -1;
                int minDist = 10000;
                for (int j = 0; j < k; j++)
                {
                    int distance = Dist(clusters[j], input[i]);
                    if (distance < minDist)
                    {
                        minDist = distance;
                        closestCluster = j;
                    }
                }
                if (assignments[i] != closestCluster)
                {
                    assignments[i] = closestCluster;
                    numChanges++;
                }
            }

            return numChanges <= 1;
        }

        private void RecalcCenters(RGB[] clusters, RGB[] input, int[] assignments, int k)
        {
            RGB[] sums = new RGB[k];
            int[] counts = new int[k];
            for (int i = 0; i < assignments.Length; i++)
            {
                int index = assignments[i];
                sums[index] += input[i];
                counts[index]++;
            }
            for (int i = 0; i < k; i++)
            {
                if (counts[i] != 0)
                {
                    clusters[i] = sums[i] / counts[i];
                }
            }
        }

        public unsafe Bitmap DrawImage()
        {
            Bitmap outputImg = new Bitmap(width, height, PixelFormat.Format8bppIndexed);

            // set palette
            ColorPalette cp = outputImg.Palette;
            int index = 0;
            for (int pal = 0; pal < numPalettes; pal++)
            {
                cp.Entries[index++] = Color.Transparent;
                for (int c = 0; c < numColors; c++)
                {
                    RGB rgb = BGpalette[pal, c];
                    Color color = Color.FromArgb(rgb.R * 8, rgb.G * 8, rgb.B * 8);
                    cp.Entries[index++] = color;
                }
            }
            outputImg.Palette = cp;

            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData imgData = outputImg.LockBits(rect, ImageLockMode.WriteOnly, outputImg.PixelFormat);
            byte* imgPtr = (byte*)imgData.Scan0;

            int tileInd = 0;
            index = 0;
            for (int y = 0; y < t_height; y++)
            {
                for (int x = 0; x < t_width; x++)
                {
                    int pal = tileAssignments[tileInd++] << 4;
                    for (int v = 0; v < 8; v++)
                    {
                        for (int u = 0; u < 8; u++)
                        {
                            int col = pixelAssignments[index++] + 1;
                            *imgPtr++ = (byte)(pal | col);
                        }
                        imgPtr += width - 8;
                    }
                    imgPtr -= width * 8 - 8;
                }
                imgPtr += width * 7;
            }
            
            outputImg.UnlockBits(imgData);
            return outputImg;
        }


    }
}
