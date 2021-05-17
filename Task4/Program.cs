using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
   /* Используя Visual Studio, создайте проект по шаблону Console Application.
Создать программу для определения синуса угла, ввод угла должен осуществлять пользователь.
   */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the degree of the angle: ");
            double corner = double.Parse(Console.ReadLine());
            const double pi = 3.14;
            double cornerInRadians = pi / 180 * corner;
            double sinys = Math.Sin(cornerInRadians);

            Console.WriteLine("Sinus = {0}",Math.Round(sinys,3));

            Console.ReadLine();
        }
    }
}
