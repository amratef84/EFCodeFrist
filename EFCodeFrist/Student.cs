using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFrist
{
    public class Student
    {
        public Student()
        {
            this.Subjects = new List<StudentSubject>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public List<StudentSubject> Subjects { get; set; }
    }
}
