using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework11._11._23
{
    public class ACipher : ICipher_
    {
        public string Encode(string input)
        {
            string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            char[] alphabet_rus = alphabet.ToCharArray();
            int Q = alphabet.Length;
            int k = 1;
            int code = 0;
            string res = "";
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    char c = chars[i];
                    int index = Array.IndexOf(alphabet_rus, c);
                    code = (Q + index + k) % Q;
                    res += alphabet_rus[code];
                }
                else
                {
                    res += chars[i];
                }
            }
            return res;
        }

        public string Decode(string input)
        {
            return input;
        }
    }
       
}
