using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        /// <summary>
        /// Итерационные конструкции C#.
        /// Глава 3.
        /// </summary>
        static void Main(string[] args)
        {
        }
        // Базовый цикл for.
        static void ForLoopExample()
        {
            // Обратите внимание, что переменная i видима только в контексте цикла for.
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Number is: {0}", i);
            }
            Console.WriteLine("==============================");

            // Здесь переменная i больше видимой не будет.
            for (int j = 5; j >= 0; j--)
            {
                Console.WriteLine($"Numbers is: {j}");
            }
            Console.WriteLine();
            // Здесь переменная j больше видимой не будет.
        }

        //Цикл foreach.
        // Проход по элементам массива посредством foreach.
        static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
            {
                Console.WriteLine($"{c}");
            }
            int[] myInt = { 10, 20, 30, 40 };
            foreach (int a in myInt)
            {
                Console.WriteLine($"{a}");
            }
        }

        //Использование неявной типизации в конструкциях foreach.
        static void LinqQueryOverlnts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            //Запрос LINQ.
            var subset = from i in numbers where i < 10 select i;
            Console.Write("Values subset: ");
            foreach (var i in subset)
            {
                Console.WriteLine($"\n{i}");
            }
        }

        //Циклы while и do/while.
        static void WhileLoopExample()
        {
            string userIsDone = "";
            // Проверить копию строки в нижнем регистре.
            while (userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while loop");
                // Запрос продолжения.
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
        }

        static void DoWhileLoopExample()
        {
            string userlsDone = "";
            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userlsDone = Console.ReadLine();
            }
            while (userlsDone.ToLower() != "yes");  //Обратите внимание на точку с запятой!
        }

        //Конструкции принятия решений
        //и операции отношения/равенства.
        //Условная операция.
        //Синтаксис if-else:
        //условие ? первое_выражение : второе_выражение;
        private static void ExecutelfElseUsingConditionalOperator()
        {
            string stringData = "My textual data";
            Console.WriteLine(stringData.Length > 0 ? "string is greater than 0 characters"
                : "string is not greater than 0 characters");
            Console.WriteLine();
        }

        //Оператор switch.
        // Переход на основе числового значения.
        static void SwitchExample()
        {
            Console.WriteLine("1 [C#]z 2 [VB]");

            // Выберите предпочитаемый язык:
            Console.Write("Please pick your language preference: ");

            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);
            switch (n)
            {
                case 1:
                    // Хороший выбор. C# - замечательный язык.
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case 2:
                    // VB: ООП, многопоточность и многое другое!
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                default:
                    // Хорошо, удачи с этим!
                    Console.WriteLine("Well... good luck with that!");
                    break;
            }
        }

        static void SwitchOnStringExample()
        {
            Console.WriteLine("C# or VB");
            Console.Write("Please pick your language preference: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading and more!");
                    break;
                default:
                    Console.WriteLine("Well... good luck with that!");
                    break;
            }
        }

        //Switch , enum.
        static void SwitchOnEnumExample()
        {
            // Введите любимый день недели:
            Console.Write("Enter your favorite day of the week: ");

            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                //Недопустимое входное значение!
                Console.WriteLine("Bad input");
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Footbal");  //Футбол.
                    break;
                case DayOfWeek.Monday:
                    // Еще один день, еще один доллар.
                    Console.WriteLine("Another day, another dollar.");
                    break;
                case DayOfWeek.Tuesday:
                    //Во всяком случае, не понедельник.
                    Console.WriteLine("At least it is not Monday.");
                    break;
                case DayOfWeek.Wednesday:
                    // Хороший денек.
                    Console.WriteLine("A fine day.");
                    break;
                case DayOfWeek.Thursday:
                    // Почти пятница...
                    Console.WriteLine("Almost Friday...");
                    break;
                case DayOfWeek.Friday:
                    //Да, пятница рулит!
                    Console.WriteLine("Yes, Friday rules!");
                    break;
                case DayOfWeek.Saturday:
                    // Действительно великолепный день.
                    Console.WriteLine("Great day indeed.");
                    break;

            }
            Console.WriteLine();
        }

        //Использование сопоставления с образцом
        //в операторах switch (нововведение).
        static void ExecutePatternMatchingSwitch()
        {
            Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal(2.5)]");
            Console.Write("Please choose option: ");
            string userChoice = Console.ReadLine();
            object choice;

            // Стандартный оператор switch, в котором применяется
            // сопоставление с образцом с константами.
            switch (userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = 2.5m;
                    break;
                default:
                    choice = 5;
                    break;
            }
            Console.WriteLine("==========================");
            // Новый оператор switch, в котором применяется
            // сопоставление с образцом с типами.
            switch (choice)
            {
                case int i:
                    Console.WriteLine("Выбрано целое число: {0}.", i);
                    break;
                case string s:
                    Console.WriteLine("Выбрана строка: {0}", s);
                    break;
                case decimal d:
                    Console.WriteLine("Выбрано десятичное число: {0}", d);
                    break;
                default:
                    Console.WriteLine("Выбрано что-то другое");
                    break;
            }
            Console.WriteLine();
        }

        static void ExecutePatternMatchingSwitchWithWhen()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please pick your language preference: ");
            object langChoice = Console.ReadLine();
            var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;

            switch (choice)
            {
                case int i when i == 2:
                case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("VB: ООП, многопоточность и многое другое!");
                    break;
                case int i when i == 1:
                case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("Хороший выбор. C# - замечательный язык.");
                    break;
                default:
                    Console.WriteLine("Хорошо, удачи с этим!");
                    break;
            }
            Console.WriteLine();
        }
    }
}
