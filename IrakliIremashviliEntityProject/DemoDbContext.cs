using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrakliIremashviliEntityProject
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    class DemoDbContext : DbContext
    {

        public DemoDbContext() : base("server=localhost;port=3306;uid=root;password=password;database=DemoEntityDB;")
        {
            Database.SetInitializer(new DemoDBInitializer());
        }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<OS> OSs { get; set; }
    }
}
