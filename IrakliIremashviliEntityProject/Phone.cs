using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrakliIremashviliEntityProject
{
    class Phone
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Model { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public virtual ICollection<OS> OSs { get; set; }
    }
}
