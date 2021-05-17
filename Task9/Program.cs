using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    /*
     Используя Visual Studio, создайте проект по шаблону Console Application.                           
    Напишите программу расчета объема - V и площади поверхности -S цилиндра. 
    Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле:  V=πr^2 h. 
    Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR(R+h). Результаты расчетов выведите на экран. 
    Пользователь должен иметь возможность вводит r – радиус цилиндра и h – высоту цилинда.
     */
    class Program
    {
        static void Main(string[] args)
        {


            const double pi = 3.14;

            Console.Write("Enter the radius of the cylinder: ");
            double r = double.Parse(Console.ReadLine());

            Console.Write("Enter the height of the cylinder: ");
            double h = double.Parse(Console.ReadLine());

            double V = pi * Math.Pow(r, 2) * h;
            double S = 2 * pi * r*(r + h);

            Console.WriteLine("The volume of cylinder = {0}",Math.Round(V,2));
            Console.WriteLine("The surface area of cylinder = {0}", Math.Round(S,2));

            Console.ReadLine();

        }
    }
}
