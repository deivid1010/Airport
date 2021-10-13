using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aeropuerto.Model
{
    public class Airport
    {
        public int id { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }
        public string region { get; set; }
        public string postalZip { get; set; }
        public string address { get; set; }
    }
}
