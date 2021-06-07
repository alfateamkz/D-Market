using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class AdminEntityActions : IEntityCreate<Admin>, IEntityGetList<Admin>, IEntityUpdate<Admin>, IAuthorization<Admin>
    {
        DatabaseModel db;
        public AdminEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }

        public List<Admin> GetList()
        {
            return db.Admins.ToList();
        }        

        public void Create(Admin entity)
        {
            db.Admins.Add(entity);
        }
        public void Update(Admin entity)
        {
            db.Admins.Update(entity);
        }
        public Admin Auth(string token, string password)
        {
            return db.Admins.Where(o => o.Token == token && o.Password == password).FirstOrDefault();
        }
    }

}
