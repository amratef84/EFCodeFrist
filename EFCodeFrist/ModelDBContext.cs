using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFrist
{
    public class ModelDBContext : DbContext
    {
        public ModelDBContext()
        {
        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=TestEFCoreCodeFrist;Integrated Security=True");

        }
    }
}
