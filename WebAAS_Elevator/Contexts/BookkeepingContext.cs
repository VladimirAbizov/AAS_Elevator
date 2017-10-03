using System.Data.Entity;

namespace WebAAS_Elevator.Models
{
    public class BookkeepingContext : DbContext
    {
        public DbSet<TTN> TTNs { get; set; }
        public DbSet<RegistryOfTTN> RegistersOfTTNs { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<PowerOfAttorney> PowersOfAttorney { get; set; }
        public DbSet<Party> Parties { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<RegistryOfTTN>()
        //        .HasMany(x => x.TTN);

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}