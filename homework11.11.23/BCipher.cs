using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework11._11._23
{
    public class BCipher: ICipher_
    {
        public string Encode(string input)
        {
            string alph1 = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string alph2 = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            char[] alphabet_Upper = alph1.ToCharArray();
            char[] alphabet_Lower = alph2.ToCharArray();
            char[] chars = input.ToCharArray();
            int d = 0;
            string res = "";
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsUpper(chars[i]))
                {
                    char letter = chars[i];
                    int index = Array.IndexOf(alphabet_Upper, letter);
                    d = alphabet_Upper.Length - index - 1;
                    res += alphabet_Upper[d];
                }
                else if (char.IsLower(chars[i]))
                {
                    char letter = chars[i];
                    int index = Array.IndexOf(alphabet_Lower, letter);
                    d = alphabet_Lower.Length - index - 1;
                    res += alphabet_Lower[d];
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
