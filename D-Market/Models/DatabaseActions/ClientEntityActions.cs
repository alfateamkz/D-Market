using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class ClientEntityActions : IEntityCreate<Client>, IEntityGetList<Client>, IEntityUpdate<Client>, IEntityBan, IAuthorization<Client>
    {
        DatabaseModel db;
        public ClientEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public Client Auth(string email, string password)
        {
            return db.Clients.Where(o => o.Email == email && o.Password == password).FirstOrDefault();
        }
        public List<Client> GetList()
        {
            return db.Clients.ToList();
        }
        public void Create(Client entity)
        {
            db.Clients.Add(entity);
        }
        public void Update(Client entity)
        {
            db.Clients.Update(entity);
        }
        public void Ban(int id)
        {
            Client obj = db.Clients.Where(o => o.ID == id).FirstOrDefault();
            obj.IsBanned = true;
            db.Clients.Update(obj);
        }
    }

}
