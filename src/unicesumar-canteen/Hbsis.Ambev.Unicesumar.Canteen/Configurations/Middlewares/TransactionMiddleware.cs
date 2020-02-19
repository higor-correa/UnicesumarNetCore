using Hbsis.Ambev.Unicesumar.Canteen.Infra.Transactions;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Api.Configurations.Middlewares
{
    public class TransactionMiddleware
    {
        private readonly RequestDelegate _next;

        public TransactionMiddleware(RequestDelegate requestDelegate)
        {
            _next = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext httpContext, ITransaction transaction)
        {
            await _next(httpContext);
            await transaction.CommitAsync();
        }
    }
}
