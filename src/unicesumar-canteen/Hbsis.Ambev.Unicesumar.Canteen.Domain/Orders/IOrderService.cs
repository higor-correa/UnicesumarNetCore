using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders.Requests;
using System;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders
{
    public interface IOrderService
    {
        Task<Order> GetAsync(Guid id);
        Task AddProductAsync(Guid orderId, Guid productId, int quantity);
        Task CancelOrderAsync(Guid orderId);
        Task<Guid> NewOrderAsync(OrderRequest orderRequest);
        Task RemoveProductAsync(Guid orderId, Guid productId, int quantity);
    }
}