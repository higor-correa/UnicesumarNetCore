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
    [Route("api/v1/orders")]
    public class OrderController : BaseController
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController
        (
            IDomainNotification domainNotification,
            IOrderService orderService,
            IMapper mapper
        ) : base(domainNotification)
        {
            _orderService = orderService;
            _mapper = mapper;
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
            var orderResponse = _mapper.Map<OrderResponse>(order);

            return order == null ? NotFound() : Result(orderResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] OrderFilter filter)
        {
            var orders = await _orderService.ListAsync(filter);
            var ordersResponse = _mapper.Map<IEnumerable<OrderResponse>>(orders);

            return Result(ordersResponse);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> CancelAsync([FromRoute]Guid id)
        {
            await _orderService.CancelOrderAsync(id);

            return Result();
        }
    }
}