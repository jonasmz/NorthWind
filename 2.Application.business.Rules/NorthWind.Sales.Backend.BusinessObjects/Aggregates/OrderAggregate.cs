namespace NorthWind.Sales.Backend.BusinessObjects.Aggregates
{
    public class OrderAggregate : Order
    {
        readonly List<OrderDetail> OrderDetailField = new();
        public IReadOnlyCollection<OrderDetail> OrderDetails => OrderDetailField;

        public void AddDetail( int productId, decimal unitPrice, short quantity){
            var ExistingOrderDetail = OrderDetailField.FirstOrDefault(od => od.ProductId == productId);
            if(ExistingOrderDetail != default){
                quantity += ExistingOrderDetail.Quantity;
                OrderDetailField.Remove(ExistingOrderDetail);
            }

            OrderDetailField.Add( new OrderDetail(productId, unitPrice, quantity) );
        }

        public static OrderAggregate From(CreateOrderDTO orderDTO){
            var OrderAggregate = new OrderAggregate{
                CustomerId = orderDTO.CustomerId,
                ShipAddress = orderDTO.ShipAddress,
                ShipCity = orderDTO.ShipCity,
                ShipCountry = orderDTO.ShipCountry,
                ShipPostalCode = orderDTO.ShipPostalCode
            };

            foreach(var item in orderDTO.OrderDetails){
                OrderAggregate.AddDetail(item.ProductId, item.UnitPrice, item.Quantity);
            }

            return OrderAggregate;
        }
    }
}