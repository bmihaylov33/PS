using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
     public class StudentData
    {
        private static List<Student> testStudents = new List<Student>();

        static Student student1 = new Student("Borislav", "Ivov", "Mihaylov", "FKST", "CSE", "bachelor", "active", "121217079", 3, 9, 35);
        
        public static List<Student> TestStudents
        {
            get
            {
                return testStudents;
            }
            set
            { 
                testStudents.Add(student1);
            }
        }
    }
}
