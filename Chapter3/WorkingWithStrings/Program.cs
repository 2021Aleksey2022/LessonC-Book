using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    /// <summary>
    /// Работа co строковыми данными.
    /// Глава 3.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
        }
        //Базовые манипуляции строками.
        static void BasicStringFunctionality()
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";

            // Значение firstName.
            Console.WriteLine("Value of firstName: {0}", firstName);

            // Длина firstname.
            Console.WriteLine("firstName has {0} characters.", firstName.Length);

            // firstName в верхнем регистре.
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());

            // firstName в нижнем регистре.
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());

            // Содержит ли firstName букву у?
            Console.WriteLine("firstName contains the letter у?:{0}", firstName.Contains("y"));

            // firstName после замены.
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));

            clock.Stop();
            Console.WriteLine($"{clock.ElapsedMilliseconds} ms");
        }

        //Конкатенация строк.
        static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation:");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2;
            string s4 = String.Concat(s1, s2);
            Console.WriteLine(s3);
            Console.WriteLine($"Второй вариант: {s4}");
            Console.WriteLine();
        }

        //Управляющие последовательности.
        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves V'Hello World\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
            // Добавить четыре пустых строки и снова выдать звуковой сигнал.
            Console.WriteLine("All finished.\n\n\n\a ");
            // Следующая строка воспроизводится дословно,
            // так что отображаются все управляющие символы.
            Console.WriteLine(@"С:\MyApp\bin\Debug");
            //Если нужны ковычки, то пишем двойные.
            Console.WriteLine(@"Cerebus said ""Darrr! Pret - ty sun - sets""");
            Console.WriteLine();
        }

        //Строки и равенство
        static void StringEquality()
        {
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            //Проверить строки и равенства.
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello1");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();
        }

        //Модификация поведения сравнения строк.
        static void StnngEqualitySpecifyingCompareRules()
        {
            Console.WriteLine("=> String equality (Case Insensitive:");
            string s1 = "Hello!";
            string s2 = "HELLO!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            // Проверить результаты изменения стандартных правил сравнения.
            Console.WriteLine("Default rules: s1 = {0}, s2 ={1} sl. Equals (s2) : {2}", s1, s2,
                s1.Equals(s2));
            Console.WriteLine("ignore case: si.Equals (s2," +
                " StringComparison.OrdinallgnoreCase) : {0}", s1.Equals(s2,
                StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("’Ignore case, Invarariant Culture: si.Equals (s2, StringComparison. InvanantCulturelgnoreCase) : {0}",
                s1.Equals(s2, StringComparison.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Default rules: sl={0}, s2={1} si.IndexOf(\"E\"): {0}",
                s1, s2, s1.IndexOf("E"));
            Console.WriteLine("Ignore case: si.IndexOf(\"E\", " +
                "StringCompanson.OrdinallgnoreCase) : {0}",
                s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invarariant Culture: si.IndexOf(\"E\", " +
                "StringComparison.InvanantCulturelgnoreCase) : {0}",
                s1.IndexOf("E", StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine();
        }

        //Строки являются неизменяемыми.
        static void StringsArelmmutable()
        {
            // Установить начальное значение для строки.
            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);

            // Преобразована ли строка s1 в верхний регистр? 
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            // Нет! Строка s1 осталась в том же виде!
            Console.WriteLine("s1 = {0}", s1);
        }

        //Тип System.Text.StringBuilder.
        static void FunWithStnngBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("***** Fantastic Games *****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", "Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars", sb.Length);
            Console.WriteLine();

            Console.WriteLine("==================================================");

            // Создать экземпляр StringBuilder с исходным размером в 256 символов.
            StringBuilder sb1 = new StringBuilder("**** Fantastic Games ****", 256);
            sb1.AppendFormat("\a\nHello");
            sb1.Append("\tvar");
            sb1.Insert(3, "dro");
            sb1.Remove(3, 5);
            sb1.Insert(3, " ");
            Console.WriteLine(sb1.ToString());
        }

        //Интерполяция строк.
        static void Stringlnterpolation()
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();
            // Некоторые локальные переменные будут включены в крупную строку.
            int age = 4;
            string name = "Soren";

            // Использование синтаксиса с фигурными скобками.
            string greeting = string.Format("Hello {0} you are {1} years old.", name.ToUpper(), age);
            Console.WriteLine(greeting);

            // Использование интерполяции строк.
            string greeting2 = $"Hello {name.ToUpper()} you are {age} years old.";
            Console.WriteLine(greeting2);
            clock.Stop();
            Console.WriteLine($"{clock.ElapsedMilliseconds}");
        }

        static void BR()
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();
            // Некоторые локальные переменные будут включены в крупную строку.
            int age = 4;
            string name = "Soren";

            // Использование синтаксиса с фигурными скобками.

            Console.WriteLine(string.Format("Hello {0} you are {1} years old.", name.ToUpper(), age));

            // Использование интерполяции строк.

            Console.WriteLine($"Hello {name.ToUpper()} you are {age} years old.");
            clock.Stop();
            Console.WriteLine($"{clock.ElapsedMilliseconds}");
        }
    }
}
