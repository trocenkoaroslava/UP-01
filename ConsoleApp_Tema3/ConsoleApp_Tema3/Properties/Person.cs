using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tema3
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        // Метод Print, который мы будем вызывать (void)
        public void Print()
        {
            Console.WriteLine("Привет, меня зовут " + Name);
        }
        // Метод 2 (void)
        public void SayBye()
        {
            Console.WriteLine("Пока!");
        }

        // Метод 3 (возвращает int)
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Метод 4 (возвращает double)
        public double Div(double a, double b)
        {
            return a / b;
        }

        // Метод 5 (возвращает string)
        public string GetName()
        {
            return Name;
        }
    }
}
