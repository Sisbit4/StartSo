using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            if (!TryInputNumber("Введите количество элементов", out n))
            {
                Console.ReadKey();
                return;
            }

            if (n < 2)
            {
                Console.WriteLine("Количествл элементов должно быть больше 2");
                Console.ReadKey();
                return;
            }

            Console.Write("Введите a1: ");
            double previousNumber = double.Parse(Console.ReadLine());

            double minAbsSum = double.MaxValue;

            for (int i = 2; i <= n; i++)
            {
                Console.Write($"Введите a{i}: ");
                double currentNumber = double.Parse(Console.ReadLine());

                double absSum = Math.Abs(previousNumber + currentNumber);

                if (absSum < minAbsSum)
                {
                    minAbsSum = absSum;
                }

                previousNumber = currentNumber;
            }

            Console.WriteLine($"Наименьшее значение суммы соседних элементов: {minAbsSum}");
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
