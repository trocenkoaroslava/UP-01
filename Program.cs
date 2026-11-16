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
            Calculator calc = new Calculator();
            Console.WriteLine("Сумма: " + calc.Add(10, 5));
            Console.WriteLine("Частное: " + calc.GetQuotient(10, 5));

            // Задание 2
            User u = new User { Id = 1, Username = "Ivan", Email = "ivan@mail.ru" };
            u.DisplayInfo();

            Console.ReadKey();
        }
    }

    public class Calculator
    {
        public int Add(int a, int b) => a + b; // 1-й метод

        private double Dev(int a, int b) => b == 0 ? 0 : (double)a / b; // 2-й метод (private)

        public double GetQuotient(int a, int b) => Dev(a, b); // Вызов private метода
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public void DisplayInfo() => Console.WriteLine($"ID: {Id}, Имя: {Username}, Email: {Email}");
    }
}
