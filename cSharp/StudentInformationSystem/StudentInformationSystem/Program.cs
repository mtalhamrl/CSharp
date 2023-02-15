using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
           bool control = true;
            Student student1 = new Student(212447,"Talha","MERAL",70,56,66,"Atılım University");
            Console.WriteLine("Welcome to our student's application ... Please select the operation you want :");
          while (control)
            {
                Console.WriteLine();

                Show();
                int select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        student1.showStudentInformations();
                        break;
                    case 2:
                        student1.studentAvarage();
                        Console.WriteLine("Avarage is = {0}", student1.studentAvarage());
                            break;
                    case 3:
                        student1.getSchool();
                        break;
                    case 4:
                        control = false;
                        break;
    
                }
            }
            Console.ReadLine();
        }
        static void Show()
        {
            Console.WriteLine("1. Show Student Informations");
            Console.WriteLine("2. Show Student Avarage");
            Console.WriteLine("3. Show Student School");
            Console.WriteLine("4. for exit");
        }
    }
}
