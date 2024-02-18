namespace NorthWind.Sales.Common.DTOs.CreateOrder
{
    public class CreateOrderDTO(
        string customerId,
        string shipAddress,
        string shipCity,
        string shipCountry,
        string shipPostalCode,
        IEnumerable<CreateOrderDetailDTO> orderDetails
    )
    {
        public string CustomerId => customerId;
        public string ShipAddress => shipAddress;
        public string ShipCity => shipCity;
        public string ShipCountry => shipCountry;
        public string ShipPostalCode => shipPostalCode;
        public IEnumerable<CreateOrderDetailDTO> OrderDetails => orderDetails;
    }
}