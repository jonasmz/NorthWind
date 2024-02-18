namespace NorthWind.Sales.Backend.UseCases.CreateOrder
{
    internal class CreateOrderInteractor(
        ICreateOrderOutputPort outputPort,
        ICommandsRepository repository) : ICreateOrderInputPort
    {
        public async Task Handle(CreateOrderDTO orderDTO)
        {
            var Order = OrderAggregate.From(orderDTO);
            await repository.CreateOrder(Order);
            await repository.SaveChanges();
            await outputPort.Handle(Order);
        }
    }
}