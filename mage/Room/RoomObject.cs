using System;
using System.Drawing;

namespace mage
{
    public abstract class RoomObject
    {
        public abstract Rectangle DrawingBounds { get; }

        public abstract RoomObject Copy();

        public abstract void SetValue(RoomObject newObj);

        public abstract RoomObject Move(Point diff, int num);

        public abstract void Add(Point pos);


    }
}
