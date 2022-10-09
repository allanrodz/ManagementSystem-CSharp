using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_17._02
{
    class Student
    {
        public int StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string County { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }

        public string MyString()
        {
            return string.Format($"{StudentNumber}{FirstName}{Surname}{County}{DOB}{Gender}");
        }

    }
}
