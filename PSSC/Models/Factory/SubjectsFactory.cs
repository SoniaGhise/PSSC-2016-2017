using Models.Generics;
using Models.Generics.Exceptions;
using System;
using Models.Subject;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Models.Factory
{
    public class SubjectsFactory
    {
        public static readonly SubjectsFactory Instance = new SubjectsFactory();
        List<Subject.Subject> _subjects;

    
        private SubjectsFactory()
        {

        }
          
        public Subject.Subject createInstance(Subject.Subject subject)
        {
            
            subject = new Subject.Subject(new Subject.SubjectInformation());

            return subject;
        }

        
    }
}
