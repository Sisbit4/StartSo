using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");

            int number;

            if (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            int countOfOnes = 0;
            int temp = number;

            while (temp > 0)
            {
                if (temp % 2 == 1) 
                {
                    countOfOnes++;
                }
                temp /= 2; 
            }

            Console.WriteLine($"Количество единиц в двоичной записи числа {number}: {countOfOnes}");

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
