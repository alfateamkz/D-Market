using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class DisputeEntityActions : IEntityCreate<Dispute>, IEntityGetList<Dispute>, IEntityUpdate<Dispute>
    {
        DatabaseModel db;
        public DisputeEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<Dispute> GetList()
        {
            return db.Disputes.ToList();
        }        

        public void Create(Dispute entity)
        {
            db.Disputes.Add(entity);
        }
        public void Update(Dispute entity)
        {
            db.Disputes.Update(entity);
        }
       
    }

}
