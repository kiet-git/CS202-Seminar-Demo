using System.Drawing;

namespace Demo1
{
    interface IColor
    {
        Color pickColor();
        Pen pickPen();
    }

    class BlueColor : IColor
    {
        private Color color = Color.Blue;
        public Color pickColor()
        {
            return color;
        }

        public Pen pickPen()
        {
            return new Pen(color);
        }
    }
    class RedColor : IColor
    {
        private Color color = Color.Red;
        public Color pickColor()
        {
            return color;
        }
        public Pen pickPen()
        {
            return new Pen(color);
        }
    }

    class DarkOrangeColor : IColor
    {
        private Color color = Color.DarkOrange;
        public Color pickColor()
        {
            return color;
        }
        public Pen pickPen()
        {
            return new Pen(color);
        }
    }

    class BlackColor : IColor
    {
        private Color color = Color.Black;
        public Color pickColor()
        {
            return color;
        }
        public Pen pickPen()
        {
            return new Pen(color);
        }
    }
}
