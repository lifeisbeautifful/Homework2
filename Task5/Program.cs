using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте две целочисленные переменные и выведите на экран результаты всех арифметических операций над этими двумя переменными.
    */

    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 20;
            int secondNumber = 10;
            
            Console.WriteLine("{0} + {1} = {2}",firstNumber,secondNumber,firstNumber+secondNumber);
            Console.WriteLine("{0} - {1} = {2}",firstNumber,secondNumber, firstNumber - secondNumber);
            Console.WriteLine("{0} * {1} = {2}",firstNumber,secondNumber, firstNumber * secondNumber);
            Console.WriteLine("{0} / {1} = {2}",firstNumber,secondNumber, firstNumber / secondNumber);
            Console.ReadLine();


        }
    }
}
