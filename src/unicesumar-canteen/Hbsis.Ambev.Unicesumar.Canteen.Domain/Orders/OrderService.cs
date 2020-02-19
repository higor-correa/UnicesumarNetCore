using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders.Requests;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderProductRepository _orderProductRepository;
        private readonly IProductRepository _productRepository;

        public OrderService
        (
            IOrderRepository orderRepository,
            IOrderProductRepository orderProductRepository,
            IProductRepository productRepository
        )
        {
            _orderRepository = orderRepository;
            _orderProductRepository = orderProductRepository;
            _productRepository = productRepository;
        }

        public async Task<Order> GetAsync(Guid id) => await _orderRepository.FindAsync(id, includes: false);

        public async Task<IEnumerable<Order>> ListAsync(OrderFilter filter) =>
            await _orderRepository.ListAsync(filter, includes: false);

        public async Task<Guid> NewOrderAsync(OrderRequest orderRequest)
        {
            var order = new Order(orderRequest.ClientName);
            await _orderRepository.AddAsync(order);

            var productsIds = orderRequest.Products.Select(x => x.ProductId).ToArray();
            var products = await _productRepository.FindAsync(productsIds);

            foreach (var productOrder in orderRequest.Products)
            {
                var product = products.FirstOrDefault(x => x.Id == productOrder.ProductId);
                var orderProduct = order.AddProduct(product, productOrder.Quantity);
                await _orderProductRepository.AddOrUpdateAsync(orderProduct);
            }

            return order.Id;
        }

        public async Task AddProductAsync(Guid orderId, Guid productId, int quantity)
        {
            var order = await _orderRepository.FindAsync(orderId);
            var product = await _productRepository.FindAsync(productId);
            var orderProduct = order.AddProduct(product, quantity);

            await _orderProductRepository.AddOrUpdateAsync(orderProduct);
            await _orderRepository.UpdateAsync(order);
        }

        public async Task RemoveProductAsync(Guid orderId, Guid productId, int quantity)
        {
            var order = await _orderRepository.FindAsync(orderId);
            var product = await _productRepository.FindAsync(productId);
            var orderProduct = order.RemoveProduct(product, quantity);

            if (orderProduct.IsEmpty())
                await _orderProductRepository.RemoveAsync(orderProduct);
            else
                await _orderProductRepository.AddOrUpdateAsync(orderProduct);

            await _orderRepository.UpdateAsync(order);
        }

        public async Task CancelOrderAsync(Guid orderId)
        {
            var order = await _orderRepository.FindAsync(orderId);

            await _orderRepository.RemoveAsync(order);

            foreach (var orderProduct in order.Products)
                await _orderProductRepository.RemoveAsync(orderProduct);
        }
    }
}
