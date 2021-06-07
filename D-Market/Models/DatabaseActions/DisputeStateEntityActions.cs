using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class DisputeStateEntityActions : IEntityGetList<DisputeState>
    {
        DatabaseModel db;
        public DisputeStateEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<DisputeState> GetList()
        {
            return db.DisputeStates.ToList();
        }
        
    }

}
