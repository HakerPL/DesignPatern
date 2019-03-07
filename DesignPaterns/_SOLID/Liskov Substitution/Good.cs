using System;
using System.Collections.Generic;

namespace DesignPaterns._SOLID.Liskov_Substitution
{
    public class RectangleGood
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public RectangleGood() { }

        public RectangleGood(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width} , {nameof(Height)}: {Height}";
        }
    }

    public class SquareGood : RectangleGood
    {
        public override int Width
        {
            set { base.Width = base.Height = value; } // that is now good
        }

        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
}
