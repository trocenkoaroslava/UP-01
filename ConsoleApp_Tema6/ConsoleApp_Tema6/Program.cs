using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tema6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. МЕТОД Parse()
            Console.WriteLine("1. Метод Parse()");
            string numberStr = "123";
            int num1 = int.Parse(numberStr);
            Console.WriteLine($"Строка '{numberStr}' через Parse стала числом: {num1}");
            Console.WriteLine();


            // 2. МЕТОД TryParse()
            Console.WriteLine("2. Метод TryParse()");
            string badNumberStr = "Привет";
            int num2;
            bool isSuccess = int.TryParse(badNumberStr, out num2);

            Console.WriteLine($"Пытаемся превратить '{badNumberStr}' в число.");
            Console.WriteLine($"Успешно? {isSuccess}. Значение переменной num2: {num2} (осталось по умолчанию 0)");
            Console.WriteLine();


            // 3. МЕТОД ParseExact()
            Console.WriteLine("3. Метод ParseExact()");
            string dateStr = "25.11.2007";
            DateTime date1 = DateTime.ParseExact(dateStr, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine($"Строка '{dateStr}' через ParseExact стала датой: {date1.ToShortDateString()}");
            Console.WriteLine();


            // 4. МЕТОД TryParseExact()
            Console.WriteLine("4. Метод TryParseExact()");
            string badDateStr = "25-11-2007"; 
            DateTime date2;
            bool isDateSuccess = DateTime.TryParseExact(
                badDateStr,
                "dd.MM.yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out date2);

            Console.WriteLine($"Пытаемся превратить '{badDateStr}' по формату 'dd.MM.yyyy'.");
            Console.WriteLine($"Успешно? {isDateSuccess}. Значение date2: {date2} (дата по умолчанию)");

            Console.ReadKey();
        }
    }
}
