using NorthWind.Sales.Backend.BusinessObjects.Interfaces.Common;

namespace NorthWind.Sales.Backend.BusinessObjects.Interfaces.Repositories
{
    public interface ICommandsRepository : IUnitOfWork
    {
        Task CreateOrder(OrderAggregate order);
    }
}