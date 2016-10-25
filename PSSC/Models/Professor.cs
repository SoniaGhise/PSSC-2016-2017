using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Professor
     {
         List<Subject> subjects = new List<Subject>();
         List<Student> students = new List<Student>();
 
        public string professorName 
        { 
            get{return professorName ;}
            set{professorName = value;}
        }
 
        public Professor(string professorName)
        {
            this.professorName = professorName;
 
        }
 
    }
}
