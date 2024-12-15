using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double proiz = 1;
            double number;

            do
            {
                if (!TryInputNumber("Введите очередной член последовательности", out number))
                {
                    Console.ReadKey();
                    return;
                }

                if (number == 0)
                {
                    Console.WriteLine($"Конец программы, произведение равно {proiz}");
                    Console.ReadKey();
                    return;
                }

                proiz *= number;

                Console.WriteLine($"Текущее прпоизведение равно {proiz}");
            } 
            while (number != 0);

            Console.WriteLine("");

            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out double number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!double.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            return true;
        }
    }
}
