using System.Drawing;
using System.Windows.Forms;


namespace Demo1
{
    abstract class Shape
    {
        protected IColor IColor;

        protected Shape(IColor c)
        {
            this.IColor = c;
        }
        protected abstract Rectangle getShape();
        public abstract void manufacture(Graphics graphics);
    }

    class Circle : Shape
    {
        private int radius;
        public Circle(IColor c, int radius) : base(c)
        {
            this.radius = radius;
        }
        protected override Rectangle getShape()
        {
            return new Rectangle(0, 0, radius, radius);
        }
        public override void manufacture(Graphics graphics)
        {
            graphics.DrawEllipse(IColor.pickPen(), getShape());
        }
    }

    class Ellipse : Shape
    {
        private int length;
        private int width;
        public Ellipse(IColor c, int length, int width) : base(c)
        {
            this.length = length;
            this.width = width;
        }
        protected override Rectangle getShape()
        {
            return new Rectangle(0, 0, length, width);
        }
        public override void manufacture(Graphics graphics)
        {
            graphics.DrawEllipse(IColor.pickPen(), getShape());
        }
    }

    class Square : Shape
    {
        private int side;
        public Square(IColor c, int side) : base(c)
        {
            this.side = side;
        }
        protected override Rectangle getShape()
        {
            return new Rectangle(0, 0, side, side);
        }

        public override void manufacture(Graphics graphics)
        {
            graphics.DrawRectangle(IColor.pickPen(), getShape());
        }

    }
    class Rectangle1 : Shape
    {
        private int length;
        private int width;
        public Rectangle1(IColor c, int length, int width) : base(c)
        {
            this.length = length;
            this.width = width;
        }
        protected override Rectangle getShape()
        {
            return new Rectangle(0, 0, length, width);
        }

        public override void manufacture(Graphics graphics)
        {
            graphics.DrawRectangle(IColor.pickPen(), getShape());
        }

    }
}
