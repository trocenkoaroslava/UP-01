using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tema7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАНИЕ 1: Методы для массивов
            Console.WriteLine("Задание 1: Работа с массивами");

            int[] array1 = { 5, 2, 8, 1, 9 };
            int[] array2 = { 3, 7, 4 };

            Console.WriteLine("Исходный массив 1: " + string.Join(", ", array1));

            // 1. Сортировка по возрастанию
            SortAscending(array1);
            Console.WriteLine("По возрастанию: " + string.Join(", ", array1));

            // 2. Сортировка по убыванию
            SortDescending(array1);
            Console.WriteLine("По убыванию: " + string.Join(", ", array1));

            // 3. Объединение двух массивов
            int[] combined = CombineArrays(array1, array2);
            Console.WriteLine("Объединенный массив: " + string.Join(", ", combined));

            // ЗАДАНИЕ 2: Разность с числом 123
            Console.WriteLine("\nЗадание 2: Разность с числом 123");

            Console.Write("Введите любое целое число (n): ");
            int n = int.Parse(Console.ReadLine());

            int result = CalculateDifference(n);
            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();
        }

        // МЕТОДЫ ДЛЯ ЗАДАНИЯ 1

        // Метод сортировки по возрастанию
        static void SortAscending(int[] arr)
        {
            Array.Sort(arr);
        }

        // Метод сортировки по убыванию
        static void SortDescending(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr); // Сначала сортируем по возрастанию потом переворачиваем
        }

        // Метод объединения двух массивов
        static int[] CombineArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            // Копируем первый массив в начало
            Array.Copy(arr1, result, arr1.Length);
            // Копируем второй массив в конец
            Array.Copy(arr2, 0, result, arr1.Length, arr2.Length);

            return result;
        }

        // МЕТОД ДЛЯ ЗАДАНИЯ 2

        static int CalculateDifference(int n)
        {
            int difference = Math.Abs(n - 123); // делает число положительным

            if (n > 123)
            {
                return difference * 3; //возвращаем тройную разность
            }

            return difference;
        }
    }
}
