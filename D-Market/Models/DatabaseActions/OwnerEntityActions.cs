using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class OwnerEntityActions : IEntityCreate<Owner>, IEntityGet<Owner>
    {
        DatabaseModel db;
        public OwnerEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<Owner> Get()
        {
            return db.Owners.ToList();
        }
        public void Create(Owner entity)
        {
            db.Owners.Add(entity);
        }
    }

}
