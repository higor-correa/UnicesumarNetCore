using Hbsis.Ambev.Unicesumar.Canteen.Domain.Users;
using System;

namespace Hbsis.Ambev.Unicesumar.Canteen.Api.Configurations.Authentications
{
    public class ScopedContext : IScopedContext
    {

        public ScopedContext() { }

        public Guid UserId { get; private set; }

        public string UserLogin { get; private set; }

        public string Role { get; private set; }
    }
}
