using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrakliIremashviliEntityProject
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            using (var db = new DemoDbContext())
            {
                Console.WriteLine("Welcome to my Entity Demo Program. \nSelect the index of desirable action");
                var exit = false;

                IList<Phone> phones = new List<Phone>();
                IList<Manufacturer> manufacturers = new List<Manufacturer>();
                IList<OS> oss = new List<OS>();

                while (!exit)
                {
                    Console.WriteLine("1)Show All Available Phones\n2)Add new phone");
                    var action = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                    switch (action)
                    {
                        case 1:
                        {
                            foreach (var phone in db.Phones)
                            {
                                Console.WriteLine(phone.Model);
                            }

                            Console.WriteLine("That's All");
                            break;
                        }

                        case 2:
                        {
                            Console.WriteLine("Enter Phone Model's Name: ");
                            var model = Console.ReadLine();
                            Console.WriteLine("Select the index of Manufacturer: ");
                            var i = 0;
                            foreach (var man in db.Manufacturers)
                            {
                                i++;
                                Console.WriteLine(i + ") " + man.Name);
                            }

                            var manIndex = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                            var chosenManufacturer = db.Manufacturers.ToArray();
                            phones.Add(new Phone {Model = model, Manufacturer = chosenManufacturer[manIndex - 1]});
                            break;
                        }
                        case 3:
                            db.Phones.AddRange(phones);
                            db.SaveChanges();
                            exit = true;
                            break;
                    }
                }
            }
        }
    }
}