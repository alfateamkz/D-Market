using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class PositionEntityActions : IEntityGetList<Position>
    {
        DatabaseModel db;
        public PositionEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<Position> GetList()
        {
            return db.Positions.ToList();
        }
        
    }

}
