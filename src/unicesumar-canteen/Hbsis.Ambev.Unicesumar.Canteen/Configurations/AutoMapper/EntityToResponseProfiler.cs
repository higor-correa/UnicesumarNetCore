using AutoMapper;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders.Responses;

namespace Hbsis.Ambev.Unicesumar.Canteen.Api.Configurations.AutoMapper
{
    public class EntityToResponseProfiler : Profile
    {
        public EntityToResponseProfiler()
        {
            CreateMap<Order, OrderResponse>();
            CreateMap<OrderProduct, OrderProductResponse>();
        }
    }
}
