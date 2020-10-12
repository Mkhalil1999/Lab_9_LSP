using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9_LSP
{
    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public int CalculateArea()
        {
            return Height * Width;
        }


    }

    class Square : Rectangle
    {
        public override int Height
        {
            get { return base.Height; }
            set { base.Height = base.Width = value; }
        }

        public override int Width
        {
            get { return base.Height; }
            set { base.Height = base.Width = value; }
        }
    }
}
