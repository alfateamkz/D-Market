using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class GlobalActionEntityActions : IEntityCreate<GlobalAction>, IEntityGetList<GlobalAction>
    {
        DatabaseModel db;
        public GlobalActionEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<GlobalAction> GetList()
        {
            return db.GlobalActions.ToList();
        }
        
        public void Create(GlobalAction entity)
        {
            db.GlobalActions.Add(entity);
        }
    }

}
