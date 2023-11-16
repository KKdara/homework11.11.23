using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework11._11._23
{
    public class Point: Figure, IShape
    {
        public Point(string color, bool is_visible): base(color, is_visible) { }
        public override void Print()
        {
            base.Print();
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
