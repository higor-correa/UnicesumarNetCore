using System;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Users
{
    public interface IScopedContext
    {
        public Guid UserId { get; }
        public string UserLogin { get; }
        public string Role { get; }
    }
}
