namespace NorthWind.Sales.Common.DTOs.CreateOrder
{
    public class CreateOrderDetailDTO(int productId, decimal price, short quantity)
    {
        public int ProductId => productId;
        public decimal Price => price;
        public short Quantity => quantity;

    }
}