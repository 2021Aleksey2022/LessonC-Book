using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    /// <summary>
    /// Сужающие и расширяющие
    ///преобразования типов данных.
    ///Глава 3.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***** Fun with type conversions *****");

            //// Добавить две переменные типа short и вывести результат.
            //short numb1 = 9, numb2 = 10;
            //Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static void ProcessBytes()
        {
            byte b1 = 150;
            byte b2 = 250;
            //На этот раз сообщить компилятору о необходимости добавления
            // кода CIL, необходимого для генерации исключениях если возникает
            // переполнение или потеря значимости.
            try
            {
                checked
                {
                    byte sum = (byte)Add(b1, b2);
                    Console.WriteLine("sum = {0}", sum);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
