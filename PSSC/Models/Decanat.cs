using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Decanat
    {
        List<Subject> subjects = new List<Subject>();
        List<Professor> professors = new List<Professor>();
        List<Student> students = new List<Student>();
 
        public List<Subject> Subject
        {
             get { return subjects; }
             set { subjects = value; }
         }
        public List<Professor> Professor
        {
             get { return professors; }
             set { professors = value; }
        }
        public List<Student> Student
        {
             get { return students; }
             set { students = value; }
        }
    }
}
