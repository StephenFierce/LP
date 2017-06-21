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
    public class StemmenRepository : IRepository<Stemmen>
    {
        public List<Stemmen> Stemmen { get { return Items; } private set { Items = value; } }
        public List<Stemmen> Items { get; private set; }
        public Stemmen Stem = new Stemmen();
        private readonly StemmenContext _context;
        public StemmenRepository(IDatabaseConnector connector)
        {
            _context = new StemmenContext(connector);
            Stemmen = new List<Stemmen>();
        }
        public void Add(Stemmen item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Stemmen item)
        {
            throw new NotImplementedException();
        }

        public List<Stemmen> GetAll(bool refresh = true, int id = 0)
        {
            Items = _context.Read(id);
            return Items;
        }

        public Stemmen GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Stemmen item)
        {
            throw new NotImplementedException();
        }
    }
}
