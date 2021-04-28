using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSeries.Interfaces
{
    public interface IRepository<T>
    {
        List<T> Lista();
        T GetById(int id);
        void Insert(T entidade);
        void Delete(int id);
        void Update(int id, T entidade);
        int NextId();
    }
}
