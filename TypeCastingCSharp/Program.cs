//1. Impliciusing System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastingCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Implicit Casting [char -> int -> long -> float -> double]
            int a = 9;
            double b = a;
            Console.WriteLine(b);

            //2. Explicit Casting [double -> float -> long -> int -> char]
            double c = 9.78;
            int myInt = (int)c;   
            Console.WriteLine(c);   
            Console.WriteLine(myInt);
            Console.ReadLine();
        }
    }
}
