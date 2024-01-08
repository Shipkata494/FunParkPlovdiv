namespace FunParkPlovdiv.Data
{
    using FunParkPlovdiv.Data.Configuration;
    using FunParkPlovdiv.Data.Models;
    using Microsoft.Data.SqlClient;
    using Microsoft.EntityFrameworkCore;
    public class FunParkPlovdivDbContext : DbContext
    {
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Prices> Prices { get; set; }
        public DbSet<User> Users { get; set; }
        public FunParkPlovdivDbContext(DbContextOptions<FunParkPlovdivDbContext> options) :base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Prices>(p => p.Property(x => x.Value)
                .HasPrecision(8, 2));
            builder.ApplyConfiguration(new PriceEntityConfiguration());
            builder.Entity<User>()
                .HasIndex(x => x.PhoneNumber)
                .IsUnique();
            base.OnModelCreating(builder);
        }
    }
}
