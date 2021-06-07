using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class ClientTransactionEntityActions : IEntityCreate<ClientTransaction>, IEntityGetList<ClientTransaction>
    {
        DatabaseModel db;
        public ClientTransactionEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<ClientTransaction> GetList()
        {
            return db.ClientTransactions.ToList();
        }
        
        public void Create(ClientTransaction entity)
        {
            db.ClientTransactions.Add(entity);
        }
    }

}
