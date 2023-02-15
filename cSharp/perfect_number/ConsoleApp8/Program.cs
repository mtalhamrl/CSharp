using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            Console.WriteLine("enter a number: ");
            number=int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
                    if (sum == number)
                    {
                        Console.WriteLine("That's a perfect number!!");
                    }
                    else
                    {
                        Console.WriteLine("It isn't a perfect number!");
                    }
                
            
            Console.ReadLine();
        }
    }
}
