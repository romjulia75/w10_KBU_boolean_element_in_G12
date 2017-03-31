using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            { 
            Console.WriteLine("Input a number");
            int n = Convert.ToInt32(Console.ReadLine());
            bool b = element_i_G12(n);
            Console.WriteLine(b);
            }

        }
        public static bool element_i_G12(int n)
            {
            bool b;
            if (n <= 100 && n > 0 && n % 12 == 0)
                b = true;
            else
                b = false;

            return b;
              
            }

    }
}
