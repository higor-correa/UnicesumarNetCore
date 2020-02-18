using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders.Requests;
using System;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders
{
    public class OrderService : IOrderService
    {
        public Task<Guid> NewOrder(OrderRequest orderRequest)
        {
            return Task.FromResult(Guid.NewGuid());
        }

        public Task AddProduct(Guid orderId, Guid productId, int quantity)
        {
            return Task.CompletedTask;
        }

        public Task RemoveProduct(Guid orderId, Guid productId, int quantity)
        {
            return Task.CompletedTask;
        }

        public Task CancelOrder(Guid orderId)
        {
            return Task.CompletedTask;
        }
    }
}
