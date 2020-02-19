using Hbsis.Ambev.Unicesumar.Canteen.Domain.Notifications;
using Microsoft.AspNetCore.Mvc;

namespace Hbsis.Ambev.Unicesumar.Canteen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private readonly IDomainNotification _domainNotification;

        public BaseController(IDomainNotification domainNotification)
        {
            _domainNotification = domainNotification;
        }

        public IActionResult Result(object result = null)
        {
            var resultData = new
            {
                _domainNotification.Errors,
                _domainNotification.Notifications,
                Data = result
            };

            return _domainNotification.HasError
                ? (IActionResult)BadRequest(resultData)
                : Ok(resultData);
        }
    }
}
