using LPProject.Core.Connection;
using LPProject.Core.Contexts;
using LPProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPProject.Core.Repositories
{
    public class PartijRepository : IRepository<Partij>
    {
        public List<Partij> Partijen { get { return Items; } private set { Items = value; } }
        public List<Partij> Items { get; private set; }
        public Partij Partij = new Partij();
        private readonly PartijContext _context;
        public PartijRepository(IDatabaseConnector connector)
        {
            _context = new PartijContext(connector);
            Partijen = new List<Partij>();
        }
        public void Add(Partij item)
        {
            _context.Create(item);
        }

        public void Delete(Partij item)
        {
            _context.Delete(item);
        }

        public List<Partij> GetAll(bool refresh = true, int id = 0)
        {
            if (refresh == true)
            {
                Items = _context.Read();
            }
            else
            {
                Partijen = Items;
            }
            return Partijen;
        }

        public Partij GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Partij item)
        {
            _context.Update(item);
        }
    }
}
