using Hbsis.Ambev.Unicesumar.Canteen.Domain.Notifications;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Transactions
{
    public class Transaction : ITransaction
    {
        private readonly IDomainNotification _domainNotification;
        private readonly DbContext _dbContext;

        public Transaction(IDomainNotification domainNotification, DbContext dbContext)
        {
            _domainNotification = domainNotification;
            _dbContext = dbContext;
        }

        public async Task CommitAsync()
        {
            if (!_domainNotification.HasError)
                await _dbContext.SaveChangesAsync();
        }
    }
}
