using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  
   public class Information
     {
         public List<Student> students =new List<Student>();
         public List<float> labGrades=new List<float>();
         public List<float> examGrades=new List<float>();
 
         public Information(List<Student> students,  List<float> labGrades, List<float> examGrades)
         {
             this.students = students;
             this.labGrades = labGrades;
             this.examGrades = examGrades;
         }
 
         public List<Student> Student
         {
             get { return students; }
             set { students = value; }
 
         }
 
         public List<float> LabGrades
         {
             get { return labGrades; }
             set { labGrades = value; }
 
         }
 
         public List<float> ExamGrades
         {
             get { return examGrades; }
             set { examGrades = value; }
 
         }
 
     }
 
   
}
