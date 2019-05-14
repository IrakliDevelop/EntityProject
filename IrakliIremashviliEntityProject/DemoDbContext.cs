using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrakliIremashviliEntityProject
{
    class DemoDbContext : DbContext
    {

        public DemoDbContext() : base("DemoEntityDB")
        {
            Database.SetInitializer(new DemoDBInitializer());
        }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<OS> OSs { get; set; }
    }
}
