using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class OrderEntityActions : IEntityCreate<Order>, IEntityGetList<Order>
    {
        DatabaseModel db;
        public OrderEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<Order> GetList()
        {
            return db.Orders.ToList();
        }
        
        public void Create(Order entity)
        {
            db.Orders.Add(entity);
        }
    }

}
