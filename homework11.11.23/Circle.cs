using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework11._11._23
{
    public class Circle: Point, IShape
    {
        public double Radius { get; set; }
        public Circle(string color, bool is_visible, double radius): base(color, is_visible)
        {
            Radius = radius;
        }
        public double CalculateArea(double radius)
        {
            return radius * radius * Math.PI;
        }
        public override void Print()
        {
            base.Print(); 
            Console.WriteLine("Radius:" + Radius, "\nArea of circle:" + CalculateArea(Radius));
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
