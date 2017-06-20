using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPProject.Models
{
    public class Coalitie
    {
        public int ID { get; set; }
        public Uitslag Uitslag { get; set; }
        public List<Partij> Partijen { get; set; }
    }
}
