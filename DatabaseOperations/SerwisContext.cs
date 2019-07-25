using System.Data.Entity;
using Serwis.Models;

namespace Serwis.DatabaseOperations
{
    public class SerwisContext : DbContext
    {
        private static SerwisContext _serwisContext;

        public static SerwisContext GetContext()
        {
            if(_serwisContext == null)
            {
                _serwisContext = new SerwisContext();
            }
            return _serwisContext;
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<RepairPosition> RepairPosition { get; set; }


        public SerwisContext()
            : base("Serwis")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Repair>()
               .HasMany(x => x.RepairPositions)
               .WithRequired()      
               .WillCascadeOnDelete();
        }
    }
}
