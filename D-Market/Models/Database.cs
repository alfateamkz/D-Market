using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using D_Market.Models.DatabaseEntities;

namespace D_Market.Models
{
    public class DatabaseModel : DbContext
    {
     
        public DatabaseModel(DbContextOptions<DatabaseModel> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientTransaction> ClientTransactions { get; set; }
        public DbSet<Dispute> Disputes { get; set; }
        public DbSet<DisputeChat> DisputeChats { get; set; }
        public DbSet<DisputeState> DisputeStates { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<GlobalAction> GlobalActions { get; set; }
        public DbSet<GlobalActionType> GlobalActionTypes { get; set; }
        public DbSet<MeasureType> MeasureTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<OwnerChat> OwnerChats { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShopChat> ShopChats { get; set; }
        public DbSet<ShopTransaction> ShopTransactions { get; set; }
        public DbSet<ShopWarehouse> ShopWarehouses { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
    }
}
