namespace NorthWind.Sales.Backend.DataContexts.EFCore.Services
{
    internal class NorthWindSalesCommandsDataContext(IOptions<DBOptions> dbOptions) : 
        NorthWindSalesContext(dbOptions), 
        INorthWindSalesCommandsDataContext
    {
        public async Task AddOrderAsync(Order order) =>
            await AddAsync(order);
            

        public async Task AddOrderDetailsAsync(IEnumerable<OrderDetail> orderDetails) =>
            await AddRangeAsync(orderDetails);

        public Task SaveChangesAsync() =>
            base.SaveChangesAsync();
    }
}