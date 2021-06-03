﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alfa.Models
{
    public class ScreenType
    {
        public int Id { get; set; }
         [Required]
         [MaxLength(15)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(20)]
        public string Model { get; set; }
        public List<ScreenLocation> ScreenLocations { get; set; }


    }
}
