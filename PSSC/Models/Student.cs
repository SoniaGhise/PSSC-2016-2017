using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student:Information
    {
        List<Subject> subjects = new List<Subject>();

         public string studentName 
         {
             get { return studentName; }
             set { studentName = value; }
         }

         public int year 
         {
             get { return year; }
             set { year = value; } 
         }
         public int registrationNumber
         {
             get { return registrationNumber; }
             set { registrationNumber = value; }
         }

         public Student(string studentName, int year, int registrationNumber, List<Student> students, List<float> labGrades, List<float> examGrades):base( students, labGrades, examGrades)
         {
             this.studentName = studentName;
             this.year = year;
             this.registrationNumber = registrationNumber;
                      
        }
    }
}
