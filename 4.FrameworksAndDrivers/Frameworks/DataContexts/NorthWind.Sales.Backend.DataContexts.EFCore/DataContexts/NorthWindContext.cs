namespace NorthWind.Sales.Backend.DataContexts.EFCore.DataContexts
{
    internal class NorthWindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../../../../NortWind.db");
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Repositories.Entities.OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}