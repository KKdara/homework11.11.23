using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework11._11._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 10.1");
            ICipher_ string1 = new ACipher();
            Console.WriteLine("Enter a string:");
            string str1 = Console.ReadLine();
            string encodeA = string1.Encode(str1);
            string decodeA = string1.Decode(str1);
            Console.WriteLine("Encoded:" + encodeA);
            Console.WriteLine("Decode:" + decodeA);

            ICipher_ string2 = new BCipher();
            Console.WriteLine("\nEnter a string:");
            string str2 = Console.ReadLine();
            string encodeB = string2.Encode(str2);
            string decodeB = string2.Decode(str2);
            Console.WriteLine("Encoded:" + encodeB);
            Console.WriteLine("Decode:" + decodeB);

            Console.WriteLine("(Press any key to continue work)");
            Console.ReadKey();
  
        }
    }
}
