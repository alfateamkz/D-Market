using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class OwnerEntityActions : IEntityCreate<Owner>, IEntityGetList<Owner>, IAuthorization<Owner>
    {
        DatabaseModel db;
        public OwnerEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }
        public Owner Auth(string email, string password)
        {
            return db.Owners.Where(o => o.Email == email && o.Password == password).FirstOrDefault();
        }
        public List<Owner> GetList()
        {
            return db.Owners.ToList();
        }
        public void Create(Owner entity)
        {
            db.Owners.Add(entity);
        }
    }

}
