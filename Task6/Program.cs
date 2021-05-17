using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Написать программу для расчета скидки за покупку, скидку и цену товара должен осуществлять пользователь.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter price of the item in hrn: ");
            double fullPrice = double.Parse(Console.ReadLine());

            Console.Write("Enter discount in %: ");
            double discount = double.Parse(Console.ReadLine());
            
            if (discount <=0)
            {
                Console.WriteLine("You don`t have any discount. The price is {0}", fullPrice); ;
            }
            else if (discount >= 100)
            {
                Console.WriteLine("You get it for free!");
            }
            else
            {

                double discountPrice = fullPrice * (discount / 100);
                Console.WriteLine("You saved {0} hrn", Math.Round(discountPrice, 2));

            }
           

                Console.ReadLine();
            
            
        }
    }
}
