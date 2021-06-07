using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class ShopWarehouseEntityActions : IEntityCreate<ShopWarehouse>, IEntityGetList<ShopWarehouse>, IEntityUpdate<ShopWarehouse>
    {
        DatabaseModel db;
        public ShopWarehouseEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<ShopWarehouse> GetList()
        {
            return db.ShopWarehouses.ToList();
        }        

        public void Create(ShopWarehouse entity)
        {
            db.ShopWarehouses.Add(entity);
        }
        public void Update(ShopWarehouse entity)
        {
            db.ShopWarehouses.Update(entity);
        }
       
    }

}
