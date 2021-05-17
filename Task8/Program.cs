using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.                                    
    Имеется 3 переменные типа int x = 10, y = 12, и z = 3; 
    Выполните и рассчитайте результат следующих операций для этих переменных: 

 x += y - x++ * z;  
z = --x – y * 5; 
y /= x + 5 % z; 
z = x++ + y * 5; 
 x = y - x++ * z;

     */
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            int z = 3;

            x += y - x++ * z;
            Console.WriteLine("x = {0}",x);
            --x;
            
            z =  y * 5;
            z = x - z;
            Console.WriteLine("z = {0}",z);

            y /= x + 5 % z;
            Console.WriteLine("y = {0}",y);
            z = x++ + y * 5;
            Console.WriteLine("z = {0}",z);
            x = y - x++ * z;
            Console.WriteLine("x = {0}",x);
            Console.ReadLine();

        }
    }
}
