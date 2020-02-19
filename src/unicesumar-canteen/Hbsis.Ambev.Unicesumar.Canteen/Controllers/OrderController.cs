using Hbsis.Ambev.Unicesumar.Canteen.Domain.Notifications;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Api.Controllers
{
    [Route("api/v1/order")]
    public class OrderController : BaseController
    {
        private readonly IOrderService _orderService;

        public OrderController
        (
            IDomainNotification domainNotification,
            IOrderService orderService
        ) : base(domainNotification)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(OrderRequest orderRequest)
        {
            var orderId = await _orderService.NewOrderAsync(orderRequest);

            return Result(orderId);
        }


        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetAsync([FromRoute] Guid id)
        {
            var order = await _orderService.GetAsync(id);

            return order == null ? NotFound() : Result(order);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> CancelAsync([FromRoute]Guid id)
        {
            await _orderService.CancelOrderAsync(id);

            return Result();
        }
    }
}