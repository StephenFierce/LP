using LPProject.Core.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPProject.Models
{
    public class Uitslag
    {
        public int ID { get; set; }
        public DateTime Datum { get; set; }
        public string Naam { get; set; }
        public Verkiezingssoort Soort { get; set; }
        public List<Stemmen> Stemmen { get; set; }

    }
}
