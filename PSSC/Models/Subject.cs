using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum ExamType
    {
        partial,
        exam
    };

    public class Subject:Professor
    {
         public string subjectName;
         ExamType examType;
         
 
        public string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }
 
         
 
         public Subject(string subjectName, ExamType examType, string professorName):base(professorName)
         {
             this.subjectName =subjectName;
             this.examType = examType;
             this.professorName = professorName;
         }
     
    }
}
