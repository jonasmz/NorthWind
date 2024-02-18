namespace NorthWind.Sales.Backend.BusinessObjects.Interfaces.CreateOrder
{
    public interface ICreateOrderInputPort
    {
        Task Handle(CreateOrderDTO orderDTO);
    }
}