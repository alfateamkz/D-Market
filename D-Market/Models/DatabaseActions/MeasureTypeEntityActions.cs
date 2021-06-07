using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class MeasureTypeEntityActions : IEntityGetList<MeasureType>
    {
        DatabaseModel db;
        public MeasureTypeEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<MeasureType> GetList()
        {
            return db.MeasureTypes.ToList();
        }
        
    }

}
