using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   /* Используя Visual Studio, создайте проект по шаблону Console Application.Создайте константу с именем -pi (число π «пи»), 
   создайте переменную радиус с именем – r.Используя формулу πR 2 , вычислите площадь круга и выведите результат на экран
   */
    class Program
    {
        static void Main(string[] args)
        {
            const double pi=3.14;
            double r = 10.5;

            double Square = pi * Math.Pow(r, 2);
            Console.WriteLine("Area of the cicle = {0}",Math.Round(Square,2));

            Console.ReadLine();
        }
    }
}
