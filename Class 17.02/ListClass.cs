using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_17._02
{
    class ListClass
    {
        public List<Student> myList = new List<Student>();

        public string AddStudent(int stuNO, string fn, string sn, string cy, string dob, string ge)
        {
            Student s = new Student();
            s.StudentNumber = stuNO;
            s.FirstName = fn;
            s.Surname = sn;
            s.County = cy;
            s.DOB = dob;
            s.Gender = ge;

            myList.Add(s);

            return "Student Added";
        }

        public string DisplayMatch(int stuNo)
        {
            foreach(Student stu in myList)
            {
                if (stu.StudentNumber == stuNo)
                {

                    return stu.MyString();
                }

            }
            return "No matches found";
        }

        public string DeleteMatch(int stuNo)
        {

            for (int i = 0; i < myList.Count; i++)
            {

                Student s = myList[i];

                if(s.StudentNumber == stuNo)
                {
                    DialogResult dr = MessageBox.Show("Delete " + s.MyString(), "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        myList.Remove(s);
                        return "Student Deleted";
                    }
                }

               
            }

            return "No matches Found";
        }
    }
}
