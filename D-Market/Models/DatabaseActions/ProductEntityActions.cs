using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class ProductEntityActions : IEntityCreate<Product>, IEntityGetList<Product>, IEntityUpdate<Product>, IEntityPseudoDelete, IEntityHide
    {
        DatabaseModel db;
        public ProductEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<Product> GetList()
        {
            return db.Products.ToList();
        }
        

        public void Create(Product entity)
        {
            db.Products.Add(entity);
        }
        public void Update(Product entity)
        {
            db.Products.Update(entity);
        }
        public void PseudoDelete(int id)
        {
            Product shop = db.Products.Where(o => o.ID == id).FirstOrDefault();
            shop.IsDeleted = true;
            db.Products.Update(shop);
        }
        public void Hide(int id)
        {
            Product shop = db.Products.Where(o => o.ID == id).FirstOrDefault();
            shop.IsHidden = true;
            db.Products.Update(shop);
        }
    }

}
