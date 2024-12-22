using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            var n = int.Parse(Console.ReadLine());
            
            if (IsStataementTrue(n))
                Console.WriteLine("Утверждение истинно");
            else
                Console.WriteLine("Утверждение ложно");

            Console.ReadKey();
        }

        static bool IsStataementTrue(int n)
        {
            return n % 4 == 0 && n % 10 != 0;
        }
    }
}
