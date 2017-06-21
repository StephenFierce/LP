using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPProject.Models
{
    public class Stemmen
    {
        public int ID { get; set; }
        public Partij Partij { get; set; }
        public int AantalStemmen { get; set; }

        public override string ToString()
        {
            return Partij.Naam + ", " + AantalStemmen;
        }
    }
}
