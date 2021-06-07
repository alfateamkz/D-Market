using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Market.Abstractions;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models.DatabaseActions
{
    public class EmployeeEntityActions : IEntityCreate<Employee>, IEntityGetList<Employee>, IEntityPseudoDelete, IEntityBan
    {
        DatabaseModel db;
        public EmployeeEntityActions(DatabaseModel databaseModel)
        {
            db = databaseModel;
        }
        public List<Employee> GetList()
        {
            return db.Employees.ToList();
        }
        public void Create(Employee entity)
        {
            db.Employees.Add(entity);
        }
        public void PseudoDelete(int id)
        {
            Employee obj = db.Employees.Where(o => o.ID == id).FirstOrDefault();
            obj.IsDeleted = true;
            db.Employees.Update(obj);
        }
        public void Ban(int id)
        {
            Employee obj = db.Employees.Where(o => o.ID == id).FirstOrDefault();
            obj.IsBanned = true;
            db.Employees.Update(obj);
        }
    }

}
