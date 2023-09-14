using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFrist.Base
{
    public class BaseEntityKeyLess
    {
        public DateTime CreateAt { get; set; }= DateTime.Now;   
        public DateTime? UpdateAt { get; set; }
        public int? CreateBy { get; set; }
        public int? UpdateBy { get; set; }
    }
}
