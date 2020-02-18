using System;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain
{
    public abstract class BaseEntity
    {
        public Guid Id { get; protected set; }
    }
}
