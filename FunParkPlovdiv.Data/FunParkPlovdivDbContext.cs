namespace FunParkPlovdiv.Data
{
    using Microsoft.EntityFrameworkCore;
    public class FunParkPlovdivDbContext : DbContext
    {
        public FunParkPlovdivDbContext(DbContextOptions<FunParkPlovdivDbContext> options) :base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
           
        }
    }
}
