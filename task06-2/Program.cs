using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "кратер";
            Console.WriteLine($"Из слова \"{s}\" получили");

            var word1 = s
                .Remove(1, 1);
            Console.WriteLine(word1);

           var word2 = s
                .Remove(0, 5)
                +s
                .Remove(0, 4)
                .Remove(1, 1)
                + s
                .Remove(1, 5)
                + s
                .Remove(0, 2)
                .Remove(1, 3);

            Console.WriteLine(word2);

            Console.ReadKey();
        }
    }
}
