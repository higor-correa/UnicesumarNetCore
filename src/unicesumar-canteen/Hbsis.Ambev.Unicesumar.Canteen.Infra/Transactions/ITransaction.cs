using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Transactions
{
    public interface ITransaction
    {
        Task CommitAsync();
    }
}
