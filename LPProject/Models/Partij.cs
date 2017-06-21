using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPProject.Models
{
    public class Partij
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public string Lijsttrekker { get; set; }

        public override string ToString()
        {
            return Naam + ", " + Lijsttrekker;
        }
    }
}
