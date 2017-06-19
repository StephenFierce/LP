using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPProject.Core.Repositories
{
    public interface IRepository<T>
    {
        void Add(T item);

        List<T> GetAll(bool refresh = true, int accountId = 0);

        void Update(T item);

        void Delete(T item);

        T GetItem(int id);
    }
}
