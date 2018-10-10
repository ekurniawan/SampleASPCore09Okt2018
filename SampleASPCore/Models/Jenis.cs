using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleASPCore.Models
{
    public class Jenis
    {
        public int JenisID { get; set; }

        [Required(ErrorMessage ="Nama Jenis harus diisi")]
        public string NamaJenis { get; set; }
    }

}
