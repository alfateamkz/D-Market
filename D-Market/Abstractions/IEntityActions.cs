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
    public interface IEntityGetList<T>
    {
        List<T> GetList();
    }
    public interface IEntityUpdate<T>
    {
        void Update(T entity);
    }

    public interface IEntityBan
    {
        void Ban(int id);
    }
    public interface IEntityPseudoDelete
    {
        void PseudoDelete(int id);
    }

    public interface IEntityHide
    {
        void Hide(int id);
    }
}
