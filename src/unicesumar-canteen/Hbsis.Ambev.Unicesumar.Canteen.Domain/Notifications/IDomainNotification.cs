using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Notifications
{
    public interface IDomainNotification
    {
        IReadOnlyCollection<string> Errors { get; }
        IReadOnlyCollection<string> Notifications { get; }

        bool HasError { get; }

        Task AddErrorAsync(string error);
        Task AddNotificationAsync(string notification);
    }
}
