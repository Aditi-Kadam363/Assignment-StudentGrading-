using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrading
{
    internal class Student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
        int[] Marks = new int[5];

        public Student(string name , int rollNo, int[] marks)
        {
            Name = name;
            RollNo = rollNo;
            for(int i = 0; i<5; i++)
            {
                Marks[i] = marks[i];
            }
            
        }

        public double CalculateAverage()
        {
            int sum = 0;
          for(int i = 0; i < Marks.Length; i++)
            {
                sum = sum + Marks[i];
            }
            return (double)sum / Marks.Length;
        }
        public string CalculateGrade()
        {
            double average = CalculateAverage();
            if( average > 90 && average < 100 )
            {
                return "Grade A+";
            }
            if(average > 80 && average < 89)
            {
                return "Grade A";
            }
            if (average > 70 && average < 79)
            {
                return "Grade B";
            }
            if (average > 60 && average < 69)
            {
                return"Grade C";
            }
            if (average > 50 && average < 59)
            {
                return "Grade D";
            }
            else
                return "Fail";
        }
        public override string ToString()
        {
            return ($"Name : {Name};  RollNo : {RollNo} ; Average : {CalculateAverage()}; Grade : {CalculateGrade()}");
        }
    }
}
