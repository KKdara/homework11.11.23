using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework11._11._23
{
    public interface IShape
    {
        void MoveHorizontally(decimal length);
        void MoveVertically(decimal length);
        void ChangeColor(string input);
    }
}
