using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    class StudentValidation
    {
        private string errorMessage;
        public Student GetStudentDataByUser(User user)
        {
            Student student = new Student();
            if (user.FacNumber == null) {
                errorMessage = "Не е посочен факултетен номер!";
            } else {
                student.name = user.Name;
                student.facultyNum = user.FacNumber;
            }

            return student;
        }
    }
}
