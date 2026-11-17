using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "Helllo, my friend!";
            Print(hello);
            void Print(string message)
            {
                Console.WriteLine(message);
            }
            Person vic = new Person("Victoriya");
            vic.Print();

            vic.SayBye();
            Console.WriteLine("Сумма: " + vic.Add(5, 5));
            Console.WriteLine("Деление: " + vic.Div(10, 2));
            Console.WriteLine("Имя из метода: " + vic.GetName());
        }
        //static void Main(string[] args)
        //{
        //    Person vic = new Person("Victoriya");
        //    vic.Print();

        //    Console.WriteLine("Введите целое число: ");
        //    int n;
        //    if(int.TryParse(Console.ReadLine(), out n))
        //    {
        //        n -= 123;
        //        Console.WriteLine($"Результат:{(n > 0 ? 3 * n : -n)}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Неправильный формат ввода!");
        //    }
        //}
    }
}
