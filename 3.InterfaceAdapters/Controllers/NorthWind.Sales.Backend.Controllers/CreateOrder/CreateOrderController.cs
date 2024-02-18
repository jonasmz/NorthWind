namespace Microsoft.AspNetCore.Builder
{
    public static class CreateOrderController
    {
        public static WebApplication UseCreateOrderController(
            this WebApplication app
        ){
            app.MapPost(Endpoints.CreateOrder, CreateOrder);

            return app;
        }
        public static async Task<int> CreateOrder(
            CreateOrderDTO orderDTO,
            ICreateOrderInputPort inputPort,
            ICreateOrderOutputPort presenter
        ){
            await inputPort.Handle(orderDTO);
            return presenter.OrderId;
        }
    }
}