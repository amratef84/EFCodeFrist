using EFCodeFrist.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFrist
{
    public class Student:BaseNameEntity
    {
        public Student()
        {
            this.Subjects = new List<StudentSubject>();
        }

        public List<StudentSubject> Subjects { get; set; }
    }
}
