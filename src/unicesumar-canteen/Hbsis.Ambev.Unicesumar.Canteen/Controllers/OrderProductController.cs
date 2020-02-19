using Hbsis.Ambev.Unicesumar.Canteen.Domain.Notifications;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Api.Controllers
{
    [Route("api/v1/orders/{id:guid}/products")]
    public class OrderProductController : BaseController
    {
        private readonly IOrderService _orderService;

        public OrderProductController
        (
            IDomainNotification domainNotification,
            IOrderService orderService
        ) : base(domainNotification)
        {
            _orderService = orderService;
        }

        [HttpPut("add")]
        public async Task<IActionResult> AddProductAsync([FromRoute]Guid id, [FromBody] OrderProductRequest orderProductRequest)
        {
            await _orderService.AddProductAsync(id, orderProductRequest.ProductId, orderProductRequest.Quantity);
            return Result();
        }

        [HttpPut("remove")]
        public async Task<IActionResult> RemoveProductAsync([FromRoute]Guid id, [FromBody] OrderProductRequest orderProductRequest)
        {
            await _orderService.RemoveProductAsync(id, orderProductRequest.ProductId, orderProductRequest.Quantity);
            return Result();
        }

    }
}
