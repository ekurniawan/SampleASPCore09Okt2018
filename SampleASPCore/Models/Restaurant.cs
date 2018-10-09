using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleASPCore.Models
{
    public class Restaurant
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Nama Restoran")]
        public string Nama { get; set; }
        [Required]
        public string Alamat { get; set; }
    }
}
