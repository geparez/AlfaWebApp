using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Alfa.Models
{
    public class Location
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("Name")]
        [Display(Name = "Institution")]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [MaxLength(11)]
        public string Telefon { get; set; }

        List<ScreenLocation> ScreenLocations { get; set; }
    }
}
