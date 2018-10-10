using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleASPCore.Models
{
    public class RumahmakanWithJenis
    {
        public int RestaurantID { get; set; }
        public int JenisID { get; set; }
        public string NamaRestaurant { get; set; }
        public string Alamat { get; set; }
        public string NamaJenis { get; set; }
    }
}
