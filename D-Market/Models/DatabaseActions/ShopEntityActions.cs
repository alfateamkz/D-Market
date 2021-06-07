using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class ShopEntityActions : IEntityCreate<Shop>, IEntityGetList<Shop>, IEntityUpdate<Shop>, IEntityPseudoDelete,IEntityBan
    {
        DatabaseModel db;
        public ShopEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<Shop> GetList()
        {
            return db.Shops.ToList();
        }        

        public void Create(Shop entity)
        {
            db.Shops.Add(entity);
        }
        public void Update(Shop entity)
        {
            db.Shops.Update(entity);
        }
        public void PseudoDelete(int id)
        {
            Shop shop = db.Shops.Where(o => o.ID == id).FirstOrDefault();
            shop.IsDeleted = true;
            db.Shops.Update(shop);
        }
        public void Ban(int id)
        {
            Shop shop = db.Shops.Where(o => o.ID == id).FirstOrDefault();
            shop.IsBanned = true;
            db.Shops.Update(shop);
        }
       
    }

}
