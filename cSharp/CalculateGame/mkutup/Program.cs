using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkutup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int first_num, second_num;
            int sum = 0 , entered_answer=0,true_answer=0,false_answer=0;
            char go;
            int total_point = 0;
            do
            {
                first_num = rnd.Next(1, 100);
                second_num = rnd.Next(1, 100);
                sum = first_num + second_num;
                Console.WriteLine("{0} + {1} = ", first_num, second_num);
                Console.WriteLine("Your answer :");
                entered_answer = int.Parse(Console.ReadLine());
                if (entered_answer == sum)
                {
                    Console.WriteLine("congratulations, your answer is correct");
                    total_point += 5;
                    true_answer++;

                }
                else
                {
                    Console.WriteLine("sorry, your answer is wrong");

                    total_point -= 2;
                    false_answer++;
                }
                Console.WriteLine("Do you want to play again?(Y/y-N/n)");
                go = Convert.ToChar(Console.ReadLine());
            }
            while (go == 'y' || go == 'Y');
            Console.WriteLine(" true answers :{0} \n false answers :{1} \n total point ={2}", true_answer, false_answer, total_point);
            Console.ReadKey();


           
        }
    }
}
