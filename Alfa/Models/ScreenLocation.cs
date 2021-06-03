using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alfa.Models
{
    public class ScreenLocation
    {
        public ScreenType ScreenType { get; set; }
        public Location Location { get; set; }

        [Key]
        [Required]
        [MaxLength(12)]
        public string SerialNumber { get; set; }
    }
}
