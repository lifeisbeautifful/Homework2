using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson2
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу для перевода метров в сантиметры (1м = 100см), ввод метров должен осуществлять пользователь.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number in meters: ");
            double meters = double.Parse(Console.ReadLine());

            double santyMeters = meters * 100;
            Console.WriteLine("{0} meters = {1} santimeters",meters,santyMeters);

            Console.ReadLine();
        }
    }
}
