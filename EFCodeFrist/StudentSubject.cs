using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFrist
{
    public class StudentSubject
    {
        public int Id { get; set; }
        public int StudentsId { get; set; }
        public Student Students { get; set; }

        public int SubjectsId { get; set; }
        public Subject Subjects { get; set; }
    }
}
