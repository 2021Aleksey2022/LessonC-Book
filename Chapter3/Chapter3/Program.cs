using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    /// <summary>
    /// Структура простой программы C#
    /// Глава 3
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
        }
        //Объявление и инициализация переменных.
        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");
            // Локальные переменные объявляются и инициализируются так:
            // типДанных имяПеременной - начальноеЗначение;
            int myInt = 0;

            // Объявлять и присваивать можно также в двух отдельных строках.
            string myString;
            myString = "This is my character data";

            // Объявить три переменных типа bool в одной строке.
            bool b1 = true, b2 = false, b3 = b1;

            // Использовать тип данных System.Boolean для объявления булевской переменной.
            System.Boolean b4 = false;
            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
            myInt, myString, b1, b2, b3, b4);

            Console.WriteLine();
        }

        //Литерал default (нововведение).
        static void DefaultDeclarations()
        {
            Console.WriteLine("=> Default Declarations:");
            int myInt = default;
            Console.WriteLine(myInt);
        }

        //Внутренние типы данных и операция new.
        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool(); // Устанавливается в false.
            int i = new int(); // Устанавливается в 0.
            double d = new double(); // Устанавливается в 0.
            System.DateTime dt = new DateTime(); // Устанавливается в 1/1/0001 12:00:00 AM
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }

        //Использование метода TryParse () для разбора
        //значений из строковых данных.
        static void ParseFromStringsWithTryParse()
        {
            Console.WriteLine("=> Data type parsing with TryParse:");
            if (bool.TryParse("True", out bool b))
            {
                Console.WriteLine("Value of b: {0}", b);  // Вывод значения b.
            }
            string value = "Hello";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d: {0}", d);  // Вывод значения d.
            }
            else
            {
                // Преобразование потерпело неудачу
                Console.WriteLine("Failed to convert the input ({0}) to a double", value);
            }
            Console.WriteLine();
        }

        //Типы System.DateTime и System.TimeSpan
        static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Dates and Times:");

            // Этот конструктор принимает год, месяц и день.
            DateTime dt = new DateTime(2015, 10, 17);

            // Какой это день месяца?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            // Сейчас месяц декабрь.
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

            // Этот конструктор принимает часы, минуты и секунды.
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            // Вычесть 15 минут из текущего значения TimeSpan и вывести результат.
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
        }

        //Сборка System.Numerics.dll
        static void UseBiglnteger()
        {
            Stopwatch clock = new Stopwatch();
            clock.Restart();
            Console.WriteLine("=> Use Biglnteger:");

            BigInteger biggy = BigInteger.Parse("9999999999999999999999999999999999999999999999");
            Console.WriteLine($"Value of biggy is: {biggy}\n {clock.ElapsedMilliseconds} ms");  //значение biggy.

            Console.WriteLine($"Is biggy an even value?: {biggy.IsEven}\n {clock.ElapsedMilliseconds} ms ");  // biggy - четное?

            Console.WriteLine("Is biggy a power of two ?: {0}", biggy.IsPowerOfTwo);  // biggy - степень 2?

            BigInteger reallyBig = BigInteger.Multiply(biggy,
                BigInteger.Parse("8888888888888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig if {0}", reallyBig);  // значение reallyBig.

            clock.Stop();
            //Console.WriteLine($"{clock.ElapsedMilliseconds} ms");
        }


    }
}
