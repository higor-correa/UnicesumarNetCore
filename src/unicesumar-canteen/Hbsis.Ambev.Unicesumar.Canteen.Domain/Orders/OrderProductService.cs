using Hbsis.Ambev.Unicesumar.Canteen.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders
{
    public class OrderProductService : IOrderProductService
    {
        private readonly IOrderProductRepository _orderProductRepository;

        public OrderProductService(IOrderProductRepository orderProductRepository)
        {
            _orderProductRepository = orderProductRepository;
        }

        public async Task<IEnumerable<OrderProduct>> GetFromOrderIdAsync(Guid orderId) =>
            await _orderProductRepository.GetFromOrderIdAsync(orderId);
    }
}
