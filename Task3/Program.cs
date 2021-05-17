using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Создать программу для определения гипотенузы прямоугольного треугольника, используя формулу с=√(a^2+) b^2, где с – гипотенуза, а b и a катеты прямоугольного треугольника.
    Ввод катетов должен осуществлять пользователь.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the legs a and b to calculate the hypotenuse");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
           
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2)) + Math.Pow(b, 2);
            Console.WriteLine("Hypotenuse = {0}",Math.Round(c,2));

            Console.ReadLine();
        }
    }
}
