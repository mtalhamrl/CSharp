using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem
{
    public class Student
    {
        private int studentNo;
        private string studentName;
        private string studentSurname;
        private int mt1;
        private int mt2;
        private int final;
        private string schoolName;

        public Student(int _studentNo, string _studentName, string _studentSurname, int _mt1, int _mt2, int _final, string _schoolName)
        {
            studentNo = _studentNo;
            studentName = _studentName;
            studentSurname = _studentSurname;
            mt1 = _mt1;
            mt2 = _mt2;
            final = _final;
            schoolName = _schoolName;
        }

        public void showStudentInformations()
        {
            Console.WriteLine("Student Number is :"+ studentNo);
            Console.WriteLine("Student Name is :" + studentName);
            Console.WriteLine("Student Surname is :" + studentSurname);
            Console.WriteLine("Student Midterm 1 is :" + mt1);
            Console.WriteLine("Student Midterm 2 is :" + mt2);
            Console.WriteLine("Student Final is :" + final);
            Console.WriteLine("Student's School's Name is :"+ schoolName);
        }
        public double studentAvarage()
        {
            double avarage = (mt1 + mt2 + final) / 3;
            return avarage;
        }
        public void getSchool()
        {
            Console.WriteLine("School's name is :" + schoolName);
        }
    }
}
