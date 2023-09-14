using EFCodeFrist.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFrist
{
    public class Card :BaseEntity
    {
        public string? Description { get; set; }
       
        public int StudentsId { get; set; }
        public Student Students { get; set; }

    }
}
