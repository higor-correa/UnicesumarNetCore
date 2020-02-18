using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders.Requests;
using System;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders
{
    public interface IOrderService
    {
        Task AddProduct(Guid orderId, Guid productId, int quantity);
        Task CancelOrder(Guid orderId);
        Task<Guid> NewOrder(OrderRequest orderRequest);
        Task RemoveProduct(Guid orderId, Guid productId, int quantity);
    }
}