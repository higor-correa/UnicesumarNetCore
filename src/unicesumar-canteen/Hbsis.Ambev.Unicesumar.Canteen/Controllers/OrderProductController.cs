using AutoMapper;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Notifications;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders.Requests;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Api.Controllers
{
    [Route("api/v1/orders/{id:guid}/products")]
    public class OrderProductController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IOrderService _orderService;
        private readonly IOrderProductService _orderProductService;

        public OrderProductController
        (
            IDomainNotification domainNotification,
            IMapper mapper,
            IOrderService orderService,
            IOrderProductService orderProductService
        ) : base(domainNotification)
        {
            _mapper = mapper;
            _orderService = orderService;
            _orderProductService = orderProductService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts([FromRoute]Guid id)
        {
            var orderProducts = await _orderProductService.GetFromOrderIdAsync(id);
            var orderProductsResult = _mapper.Map<IEnumerable<OrderProductResponse>>(orderProducts);

            return Result(orderProductsResult);
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
