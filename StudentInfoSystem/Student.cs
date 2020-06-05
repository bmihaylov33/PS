using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class Student
    {
        public string name;
        public string middleName;
        public string lastName;
        public string faculty;
        public string module;
        public string degree;
        public string status;
        public string facultyNum;
        public int course;
        public int stream;
        public int group;

        public Student(string name, string middleName, string lastName, string faculty, string module, string degree, string status, string facultyNum, int course, int stream, int group)
        {
            this.name = name;
            this.middleName = middleName;
            this.lastName = lastName;
            this.faculty = faculty;
            this.module = module;
            this.degree = degree;
            this.status = status;
            this.facultyNum = facultyNum; 
            this.course = course;
            this.stream = stream;
            this.group = group;
        }

        public Student()
        {

        }
    }
}
