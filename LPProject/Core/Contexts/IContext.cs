using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPProject.Core.Contexts
{
    public interface IContext<T>
    {
        void Create(T item, int id = 0);

        List<T> Read(int accountId = 0);

        void Update(T item);

        void Delete(T item);

        T GetItem(int id);
    }
}
