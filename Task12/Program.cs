using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число m от 5 до 20");
            int m;

            if (!TryInputNumber(out m))
            {
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите целое число n");
            int n;

            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }

            if (m < 5 || m > 20 || n < 5 || n > 20)
            {
                Console.WriteLine("Числа не удовлетворяют неравенству 5 <= m,n <= 20");
                Console.ReadKey();
                return;
            }

            var matrix = new int[m, n];
            var rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(100);

            Console.WriteLine();

            PrintMatrix(matrix);

            Console.WriteLine();

            Console.WriteLine("Введите число для проверки элементов массива:");
            if (!int.TryParse(Console.ReadLine(), out int threshold))
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            if (FindElementLessThan(matrix, threshold, out int row, out int column))
            {
                Console.WriteLine($"Элемент меньше {threshold} найден в строке {row}, колонке {column}.");
            }
            else
            {
                Console.WriteLine($"В массиве нет элементов меньше {threshold}.");
            }

            Console.WriteLine();

            Console.WriteLine("Произведение нечетных элементов в каждой строке:");
            CalculateOddProducts(matrix);

            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            number = n;
            return true;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],2} ");

                Console.WriteLine();
            }
        }
        static bool FindElementLessThan(int[,] matrix, int threshold, out int row, out int column)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < threshold)
                    {
                        row = i;
                        column = j;
                        return true;
                    }
                }
            }
            row = -1;
            column = -1;
            return false;
        }
        static void CalculateOddProducts(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int product = 1;
                bool hasOdd = false;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        product *= matrix[i, j];
                        hasOdd = true;
                    }
                }
                Console.WriteLine($"Строка {i}: произведение = {(hasOdd ? product : 0)}");
            }
        }
    }
}