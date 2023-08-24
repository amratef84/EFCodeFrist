using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFrist
{
    public class Subject
    {
        public Subject()
        {
            this.Students = new List<StudentSubject>();
        }
        public int Id { get; set; }
        public string Name { get; set; }


        public int TeachersId { get; set; }
        public Teacher  Teachers { get; set; }

        public List<StudentSubject> Students { get; set; }
    }
}
