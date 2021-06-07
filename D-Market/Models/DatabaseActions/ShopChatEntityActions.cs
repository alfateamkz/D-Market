using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class ShopChatEntityActions : IEntityCreate<ShopChat>, IEntityGetList<ShopChat>
    {
        DatabaseModel db;
        public ShopChatEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<ShopChat> GetList()
        {
            return db.ShopChats.ToList();
        }
        
        public void Create(ShopChat entity)
        {
            db.ShopChats.Add(entity);
        }
    }

}
