using Hbsis.Ambev.Unicesumar.Canteen.Domain.Notifications;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Notifications
{
    public class DomainNotification : IDomainNotification
    {
        private readonly List<string> _errors;
        private readonly List<string> _notifications;

        public IReadOnlyCollection<string> Errors => _errors.AsReadOnly();
        public IReadOnlyCollection<string> Notifications => _notifications.AsReadOnly();
        public bool HasError { get; private set; }
        public bool HasNotification { get; private set; }

        public DomainNotification()
        {
            _errors = new List<string>();
            _notifications = new List<string>();
        }

        public Task AddErrorAsync(string error)
        {
            HasError = true;
            HasNotification = true;
            _errors.Add(error);
            return Task.CompletedTask;
        }

        public Task AddNotificationAsync(string notification)
        {
            HasNotification = true;
            _notifications.Add(notification);
            return Task.CompletedTask;
        }
    }
}
