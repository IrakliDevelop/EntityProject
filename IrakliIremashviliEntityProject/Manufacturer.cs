﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrakliIremashviliEntityProject
{
    class Manufacturer
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

    }
}
