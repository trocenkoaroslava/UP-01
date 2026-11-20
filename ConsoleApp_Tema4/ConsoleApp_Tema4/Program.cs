using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Пример 1
            Console.WriteLine("1)");
            try
            {
                int x = 5;
                int y = x / 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }



            //Пример 2
            //Console.WriteLine("2)");
            //try
            //{
            //    int[] numbers = new int[4];
            //    numbers[7] = 9; // IndexOutOfRangeException 

            //    int x = 5;
            //    int y = x / 0;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Возникло исключение DivideByZeroException");
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}




            //Пример 3
            //Console.WriteLine("3) Фильтр исключений ");
            //int x1 = 2;
            //int y1 = 3; //чтобы появилась ошибка, у должен быть равен нулю

            //try
            //{
            //    int result = x1 / y1;
            //    int result2 = y1 / x1;
            //}
            //catch (DivideByZeroException) when (y1 == 0)
            //{
            //    Console.WriteLine("У не дожен быть равен нулю");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadKey();
        }
    }
}
