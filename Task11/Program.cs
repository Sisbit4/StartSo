using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива");

            int n;

            if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            Console.Write("Введите начало диапазона a ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите конец диапазона b ");

            int b = int.Parse(Console.ReadLine());

            if (a >= b || a < -20 || b > 20)
            {
                Console.WriteLine($"Диапазон должен удовлетворять условию −20 <= a < b <= 20.");
                Console.ReadKey();
                return;
            }

            int[] numbers = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(a, b + 1);
            }

            Console.WriteLine("Массив чисел равен:");
            PrintArray(numbers);

            ChangeArray(numbers);
            Console.WriteLine("Массив после изменения знаков:");
            PrintArray(numbers);

            double sqrtOfSumOfSquares = GetSqrtOfSumOfSquares(numbers);
            Console.WriteLine($"Квадратный корень из суммы квадратов элементов массива: {sqrtOfSumOfSquares}");

            int[] factorialArray = GetFactorials(numbers);
            Console.WriteLine("Массив факториалов модулей элементов:");
            PrintArray(factorialArray);

            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }

        static void ChangeArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = -array[i];
            }
        }

        static double GetSqrtOfSumOfSquares(int[] array)
        {
            double sumOfSquares = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumOfSquares += array[i] * array[i]; 
            }
            return Math.Sqrt(sumOfSquares); 
        }

        static int[] GetFactorials(int[] array)
        {
            if (array == null || array.Length == 0)
                return new int[0];

            int[] factorials = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                factorials[i] = CalculateFactorial(Math.Abs(array[i])); 
            }
            return factorials;
        }

        static int CalculateFactorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1; 
            }
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
