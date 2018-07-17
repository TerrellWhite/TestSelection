using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSelectionStatementsJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            /*Console.Write("Please enter your age:");
            int input1 = int.Parse(Console.ReadLine());
            
            //process
            if (input1 >= 21)
            {
                Console.WriteLine("You can buy Beer!");
            }
            else
            {
                Console.WriteLine("Ask a homeless guy to do it for you.");
            }*/
            //Decide if user is old enough to drive
            //input
            Console.Write("Please enter your age:");
            double input1 = double.Parse(Console.ReadLine());

            if(input1 >= 18)
            {
                Console.WriteLine("You can drive!");
            }
            else if(input1 >= 16){
                Console.WriteLine("You can drive but you need someone with a vaild licence next to you!");
            }
            else
            {
                Console.WriteLine("Ride a bike");
            }
        }
    }
}
