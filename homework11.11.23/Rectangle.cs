using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework11._11._23
{
    public class Rectangle:  Point, IShape 
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height, string color, bool is_visible): base(color, is_visible) 
        {
            Width = width;
            Height = height;
        }
        public double CalculateArea(double width, double height)
        {
            return width * height;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Width:" +  Width, "\nHeight:" + Height, "Area of rectangle:" + CalculateArea(Width, Height));
        }

        public void MoveHorizontally(decimal length)
        {

        }
        public void MoveVertically(decimal length)
        {

        }
        public void ChangeColor(string input)
        {
            Color = input;
        }
    }
}
