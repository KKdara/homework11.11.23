using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework11._11._23
{
    public interface ICipher_
    {
        string Encode(string input);
        string Decode(string input);
    }
}
