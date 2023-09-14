using EFCodeFrist.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFrist
{
    public class Teacher : BaseNameEntity
    {
        public Teacher()
        {
            this.Subjects = new List<Subject>();
        }

        public List<Subject> Subjects { get; set; }

    }
}
