using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework11._11._23
{
    public abstract class Figure
    {
        public string Color { get; set; }
        public bool IsVisible { get; set; }
        public Figure(string color, bool is_visible)
        {
            Color = color;
            IsVisible = is_visible;
        }
        public bool VisibleOrNot(bool answer)
        {
            if (answer == true)
            {
                IsVisible = true;
                
            }
            return IsVisible;
        }
        public virtual void Print()
        {
            Console.WriteLine("Color:" + Color, "\nVisible or not:" + IsVisible);
        }
    }
}
