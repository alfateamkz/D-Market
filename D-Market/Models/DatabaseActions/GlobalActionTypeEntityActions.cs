using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class GlobalActionTypeEntityActions : IEntityGetList<GlobalActionType>
    {
        DatabaseModel db;
        public GlobalActionTypeEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<GlobalActionType> GetList()
        {
            return db.GlobalActionTypes.ToList();
        }
        
    }

}
