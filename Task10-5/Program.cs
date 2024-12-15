using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            if (!TryInputNumber("Введите числитель ", out m))
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }
            int n;
            if (!TryInputNumber("Введите знаменатель", out n) || n <= 0)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            int deli = 1;
            int limit = Math.Min(Math.Abs(m), Math.Abs(n)); 

            for (int i = 1; i <= limit; i++)
            {
                if (m % i == 0 && n % i == 0)
                {
                    deli = i;
                }
            }

            int p = m / deli;
            int q = n / deli;

            Console.WriteLine($"Сокращенная дробь: {p}/{q}");

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
