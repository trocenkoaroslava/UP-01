using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine("Задание 1: Калькулятор");
            Calculator calc = new Calculator();
            Console.WriteLine("Сумма (10 + 5)= " + calc.Add(10, 5));
            Console.WriteLine("Частное (10 / 5)= " + calc.Get(10, 5));

            // Задание 2
            Console.WriteLine("\nЗадание 2: Пользователь");
            User u = new User();

            // Запрашиваем данные у пользователя
            Console.Write("Введите ID пользователя (число): ");
            u.Id = int.Parse(Console.ReadLine());

            Console.Write("Введите имя (Username): ");
            u.Username = Console.ReadLine();

            Console.Write("Введите Email: ");
            u.Email = Console.ReadLine();

            // Выводим результат
            Console.WriteLine("\nДанные сохранены:");
            u.DisplayInfo();

            Console.ReadKey();
        }
    }

    public class Calculator
    {
        public int Add(int a, int b) => a + b;

        private double Dev(int a, int b) => b == 0 ? 0 : (double)a / b;

        public double Get(int a, int b) => Dev(a, b);

    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public void DisplayInfo() => Console.WriteLine($"ID: {Id}, Имя: {Username}, Email: {Email}");
    }
}
