using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFrist
{
    public class Teacher
    {
        public Teacher()
        {
            this.Subjects = new List<Subject>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Subject> Subjects { get; set; }

    }
}
