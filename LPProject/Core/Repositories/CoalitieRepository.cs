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
    public class CoalitieRepository : IRepository<Coalitie>
    {
        public List<Coalitie> Coalitieen { get { return Items; } private set { Items = value; } }
        public List<Coalitie> Items { get; private set; }
        public Coalitie Coalitie = new Coalitie();
        private readonly CoalitieContext _context;
        public CoalitieRepository(IDatabaseConnector connector)
        {
            _context = new CoalitieContext(connector);
            Coalitieen = new List<Coalitie>();
        }
        public void Add(Coalitie item)
        {
            _context.Create(item);
        }

        public void Delete(Coalitie item)
        {
            _context.Delete(item);
        }

        public List<Coalitie> GetAll(bool refresh = true, int id = 0)
        {
            if (refresh == true)
            {
                Items = _context.Read();
            }
            else
            {
                Coalitieen = Items;
            }
            return Coalitieen;
        }

        public Coalitie GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Coalitie item)
        {
            _context.Update(item);
        }
    }
}
