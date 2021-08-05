using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_15___class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region foreach
            student[] grade = new student[3] { new student(90), new student(85), new student(95) };
            foreach (student StudentGrade in grade)
            {
                Console.WriteLine(StudentGrade.Grade);
            }
            #endregion
        }
    }
    class student
    {
        public student(double grade)
        {
            Grade = grade;
        }

        public double Grade { get; set; }
    }
    
}
