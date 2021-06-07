using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class DisputeChatEntityActions : IEntityCreate<DisputeChat>, IEntityGetList<DisputeChat>
    {
        DatabaseModel db;
        public DisputeChatEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<DisputeChat> GetList()
        {
            return db.DisputeChats.ToList();
        }
        
        public void Create(DisputeChat entity)
        {
            db.DisputeChats.Add(entity);
        }
    }

}
