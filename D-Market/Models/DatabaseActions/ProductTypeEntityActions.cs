using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class ProductTypeEntityActions : IEntityGetList<ProductType>
    {
        DatabaseModel db;
        public ProductTypeEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<ProductType> GetList()
        {
            return db.ProductTypes.ToList();
        }
        
    }

}
