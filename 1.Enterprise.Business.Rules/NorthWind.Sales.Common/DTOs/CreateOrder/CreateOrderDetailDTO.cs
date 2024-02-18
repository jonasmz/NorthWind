namespace NorthWind.Sales.Common.DTOs.CreateOrder
{
    public class CreateOrderDetailDTO(int productId, decimal unitPrice, short quantity)
    {
        public int ProductId => productId;
        public decimal UnitPrice => unitPrice;
        public short Quantity => quantity;

    }
}