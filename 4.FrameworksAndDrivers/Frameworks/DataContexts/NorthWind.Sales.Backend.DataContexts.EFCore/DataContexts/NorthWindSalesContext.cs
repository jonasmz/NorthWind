namespace NorthWind.Sales.Backend.DataContexts.EFCore.DataContexts
{
    public class NorthWindSalesContext(IOptions<DBOptions> dbOptions) : DbContext
    {
        IOptions<DBOptions> DbOptions => dbOptions;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbOptions.Value.ConnectionString}");
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}