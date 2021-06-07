using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D_Market.Abstractions
{
    public interface IEntityCreate<T>
    {
        void Create(T entity);
    }

    public interface IEntityGet<T>
    {
        List<T> Get();
    }
    public interface IEntityUpdate<T>
    {
        void Update(T entity);
    }

    public interface IEntityPseudoDelete
    {
        void PseudoDelete(int id);
    }
}
