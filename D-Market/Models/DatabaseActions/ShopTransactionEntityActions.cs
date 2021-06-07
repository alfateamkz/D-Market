using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class ShopTransactionEntityActions : IEntityCreate<ShopTransaction>, IEntityGetList<ShopTransaction>
    {
        DatabaseModel db;
        public ShopTransactionEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<ShopTransaction> GetList()
        {
            return db.ShopTransactions.ToList();
        }
        
        public void Create(ShopTransaction entity)
        {
            db.ShopTransactions.Add(entity);
        }
    }

}
