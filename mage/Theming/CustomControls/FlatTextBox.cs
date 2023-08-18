using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Versioning;
using System.Drawing.Drawing2D;

namespace mage.Theming.CustomControls;

[SupportedOSPlatform("windows")]
partial class FlatTextBox : UserControl
{
    #region Properties

    public override Color BackColor
    {
        get => textBox.BackColor;
        set
        {
            textBox.BackColor = value;
            base.BackColor = value;
        }
    }
    public bool Multiline
    {
        get => textBox.Multiline;
        set
        {
            textBox.Multiline = value;
        }
    }

    private Color borderColor = Color.Black;
    public Color BorderColor
    {
        get => borderColor;
        set
        {
            borderColor = value;
            Invalidate();
        }
    }
    private bool drawBorder = true;

    public override Color ForeColor { get => textBox.ForeColor; set => textBox.ForeColor = value; }
    public bool ReadOnly { get => textBox.ReadOnly; set => textBox.ReadOnly = value; }

    public new BorderStyle BorderStyle
    {
        get => textBox.BorderStyle;
        set
        {
            drawBorder = true;
            if (value == BorderStyle.None)
            {
                textBox.Location = new Point(0, 0);
                drawBorder = false;
            }
            else textBox.Location = new Point(3, 3);
        }
    }

    public override string Text { get => textBox.Text; set => textBox.Text = value; }

    public bool WordWrap { get => textBox.WordWrap; set => textBox.WordWrap = value; }

    public int SelectionStart { get => textBox.SelectionStart; set => textBox.SelectionStart = value; }

    public ScrollBars ScrollBars { get => textBox.ScrollBars; set => textBox.ScrollBars = value; }

    public override bool Focused
    {
        get
        {
            if (textBox.Focused || base.Focused) return true;
            return false;
        }
    }
    #endregion

    #region events
    public new event EventHandler TextChanged
    {
        add { textBox.TextChanged += value; }
        remove { textBox.TextChanged -= value; }
    }
    #endregion

    public FlatTextBox()
    {
        InitializeComponent();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        //Draw Border
        if (!drawBorder) return;

        Rectangle border = new Rectangle(Point.Empty, Size);
        border.Width--; border.Height--;
        Pen p = new Pen(BorderColor);
        e.Graphics.DrawRectangle(p, border);
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);

        if (Multiline) return;
        else Height = 23;
    }

    private void FlatTextBox_MouseDown(object sender, MouseEventArgs e)
    {
        textBox.Focus();
    }

    //Conversions
    public static implicit operator TextBox(FlatTextBox b) => b.textBox;
}
