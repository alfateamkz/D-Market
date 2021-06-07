using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class OwnerChatEntityActions : IEntityCreate<OwnerChat>, IEntityGetList<OwnerChat>
    {
        DatabaseModel db;
        public OwnerChatEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<OwnerChat> GetList()
        {
            return db.OwnerChats.ToList();
        }
        
        public void Create(OwnerChat entity)
        {
            db.OwnerChats.Add(entity);
        }
    }

}
