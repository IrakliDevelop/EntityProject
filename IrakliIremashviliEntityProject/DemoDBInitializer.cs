using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrakliIremashviliEntityProject
{
    class DemoDBInitializer : DropCreateDatabaseIfModelChanges<DemoDbContext>
    {
        protected override void Seed(DemoDbContext context)
        {
            IList<Manufacturer> manufacturers = new List<Manufacturer>();

            manufacturers.Add(new Manufacturer() { Name = "Samsung", });
            manufacturers.Add(new Manufacturer() { Name = "Lenovo", });
            manufacturers.Add(new Manufacturer() { Name = "Sony", });

            context.Manufacturers.AddRange(manufacturers);

            IList<OS> oss = new List<OS>();

            oss.Add(new OS() { Name = "Android", });
            oss.Add(new OS() { Name = "Symbian", });
            oss.Add(new OS() { Name = "IrakliOS", });

            context.OSs.AddRange(oss);

            IList<Phone> phones = new List<Phone>();

            phones.Add(new Phone() { Id = 1, Model = "Galaxy S5", Manufacturer = manufacturers[0], });

            context.Phones.AddRange(phones);


            base.Seed(context);
        }
    }
}
