using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MyMethods
    {
        // 2 метода void
        public void PrintHello() => Console.WriteLine("Привет из DLL!");
        public void SayBye() => Console.WriteLine("Пока!");

        // 3 метода с возвращаемыми значениями разных типов
        public int Add(int a, int b) => a + b;
        public double Div(double a, double b) => b == 0 ? 0 : a / b;
        public string GetName() => "Ярослава";
    }
}
