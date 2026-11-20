using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tema5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Привет, мир!";
            string str2 = "привет, МИР!";
            string str3 = "Привет, мир!"; // Точно такая же как str1

            Console.WriteLine($"Строка 1: {str1}");
            Console.WriteLine($"Строка 2: {str2}");
            Console.WriteLine($"Строка 3: {str3} (копия строки 1)\n");

            // 1. Compare() - сравнивает с учетом регистра (какая строка больше/меньше по алфавиту)
            int compareResult = string.Compare(str1, str2);
            Console.WriteLine($"1.Compare(str1, str2): {compareResult} (не 0, так как регистр разный)");
            Console.WriteLine($"  Compare(str1, str3): {string.Compare(str1, str3)} (0, так как они одинаковые)");

            // 2. Equals() - проверяет на полное совпадение (с учетом регистра)
            bool isEquals = str1.Equals(str2);
            Console.WriteLine($"\n2.Equals(str1, str2): {isEquals}");
            Console.WriteLine($"  Equals(str1, str3): {str1.Equals(str3)}");

            // 3. CompareOrdinal() - сравнивает по кодам символов (побайтово без учета языковых особенностей)
            int ordinalResult = string.CompareOrdinal(str1, str2);
            Console.WriteLine($"\n3.CompareOrdinal(str1, str2): {ordinalResult}");

            // 4. IndexOf() - ищет под каким индексом (позицией) находится слово или буква
            int index = str1.IndexOf("мир");
            Console.WriteLine($"\n4.IndexOf(\"мир\") в str1: {index}");

            // 5. Contains() - проверяет, содержится ли кусочек текста внутри строки (возвращает true/false)
            bool contains = str1.Contains("Привет");
            Console.WriteLine($"\n5.Contains(\"Привет\") в str1: {contains}");

            // 6. Операторы == и != 
            Console.WriteLine($"\n6.str1 == str3: {str1 == str3}");
            Console.WriteLine($"  str1 != str2: {str1 != str2}");

            Console.ReadKey();
        }
    }
}
