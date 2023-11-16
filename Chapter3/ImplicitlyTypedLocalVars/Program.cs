using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypedLocalVars
{
    /// <summary>
    /// Понятие неявно типизированных
    ///локальных переменных.
    ///Глава 3.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
        }
        //Полезность неявно типизированных локальных переменных.
        static void LinqQueryOverlnts()
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            // Запрос LINQ!
            var subset = from i in numbers where i < 10 select i;
            Console.Write("Values in subset: ");
            foreach (var i in subset)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine();

            // К какому же типу относится subset?
            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
            clock.Stop();
            Console.WriteLine($"{clock.ElapsedMilliseconds} ms");
        }

        //Метод Numbers работает быстрей на 4 мили секунды, чем метод с запросом LINQ
        static void Numbers()
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        sum = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = sum;
                    }
                }

            }
            Console.WriteLine();
            foreach (int i in numbers)
            {
                Console.Write("{0}\t", i);
            }
            Console.WriteLine();
            clock.Stop();
            Console.WriteLine($"{clock.ElapsedMilliseconds} ms");
        }
    }
}
