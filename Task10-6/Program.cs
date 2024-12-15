using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            if (!TryInputNumber("Введите число n", out n) || n <= 0)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            var sum = 0;

            for (int i = 1; i <= n; i++)
            {
                var a = 1; 
                for (int j = 1; j <= i; j++)
                {
                    a *= i;
                }
                sum += a;
            }

            Console.WriteLine($"Сумма для {n} равна {sum}");
            Console.ReadKey();
        }

        static bool TryInputNumber(string massage, out int number)
        {
            Console.WriteLine(massage);
            var input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            return true;
        }
    }
}
