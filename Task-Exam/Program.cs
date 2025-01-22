using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Циклические простые числа до 1000000:");

            int n = 1000000;
            for (int i = 2; i < n; i++)
            {
                if (IsCyclicPrime(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Конец программы");

            Console.ReadKey();
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public static bool IsCyclicPrime(int number)
        {
            if (!IsPrime(number)) return false;

            string chislo = number.ToString();
            int len = chislo.Length;

            for (int i = 1; i < len; i++)
            {
                chislo = chislo.Substring(1) + chislo[0];
                if (!IsPrime(int.Parse(chislo)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
