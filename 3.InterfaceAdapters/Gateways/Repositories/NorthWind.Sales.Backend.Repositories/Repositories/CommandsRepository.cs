namespace NorthWind.Sales.Backend.Repositories.Repositories
{
    internal class CommandsRepository(INorthWindSalesCommandsDataContext context) : ICommandsRepository
    {
        public async Task CreateOrder(OrderAggregate order)
        {
            await context.AddOrderAsync(order);
            await context.AddOrderDetailsAsync(
                order.OrderDetails
                    .Select(od => new Entities.OrderDetail{
                        Order = order,
                        ProductId = od.ProductId,
                        UnitPrice = od.UnitPrice,
                        Quantity = od.Quantity
                    }).ToList()
            );
        }

        public async Task SaveChanges() => 
            await context.SaveChangesAsync();
    }
}