using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace konyvaruhaz.Models
{
    public class Poszt
    {
        public int id { get; set; }
        public DateTime datum { get; set; }
        public string bejegyzes { get; set; }
    }
}