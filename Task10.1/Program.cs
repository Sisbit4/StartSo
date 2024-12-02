using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            if (!TryInputNumber("Введите число a", out a))
            {
                Console.ReadKey();
                return;
            }

            int b = 0;
            if (!TryInputNumber("Введите число b", out b))
            {
                Console.ReadKey();
                return;
            }

            if (a >= b)
            {
                Console.WriteLine("Условие a < b не выполняеся");
                Console.ReadKey();
                return;
            }

            var product = 0;

            for (var i = a; i <= b; i++)
                product += i*i;

            Console.WriteLine($"Сумма кватратов чисел от {a} до {b} равно {product}");

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
