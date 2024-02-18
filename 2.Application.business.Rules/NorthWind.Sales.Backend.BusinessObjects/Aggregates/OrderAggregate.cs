namespace NorthWind.Sales.Backend.BusinessObjects.Aggregates
{
    public class OrderAggregate : Order
    {
        readonly List<OrderDetail> OrderDetailField = new();
        public IReadOnlyCollection<OrderDetail> OrderDetails => OrderDetailField;

        public void AddDetail( int productId, decimal unitPrice, short quantity){

        }
    }
}