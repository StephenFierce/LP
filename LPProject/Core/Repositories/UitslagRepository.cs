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
    public class UitslagRepository : IRepository<Uitslag>
    {
        public List<Uitslag> Uitslagen { get { return Items; } private set { Items = value; } }
        public List<Uitslag> Items { get; private set; }
        public Uitslag uitslag = new Uitslag();
        private readonly UitslagContext _context;
        public UitslagRepository(IDatabaseConnector connector)
        {
            _context = new UitslagContext(connector);
            Uitslagen = new List<Uitslag>();
        }
        public void Add(Uitslag item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Uitslag item)
        {
            throw new NotImplementedException();
        }

        public List<Uitslag> GetAll(bool refresh = true, int id = 0)
        {
            Uitslagen = _context.Read();
            return Uitslagen;
        }

        public Uitslag GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Uitslag item)
        {
            _context.Update(item);
        }
    }
}
