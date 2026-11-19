using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethods myClass = new MyMethods(); // Создаем объект из DLL

            // Тестируем
            myClass.PrintHello();
            myClass.SayBye();
            Console.WriteLine("Сумма: " + myClass.Add(10, 5));
            Console.WriteLine("Частное: " + myClass.Div(10, 4));
            Console.WriteLine("Имя: " + myClass.GetName());
            // Сюда мы напишем код чуть позже
            Console.ReadKey();
        }
    }
}
