using System;
using System.Collections.Generic;

namespace DesignPaterns._SOLID.Liskov_Substitution
{
    public class RectangleWrong
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public RectangleWrong() { }

        public RectangleWrong(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width} , {nameof(Height)}: {Height}";
        }
    }

    public class SquareWrong : RectangleWrong
    {
        public new int Width
        {
            set { base.Width = base.Height = value; } // that is now good
        }

        public new int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
}
