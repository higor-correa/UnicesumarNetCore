using Hbsis.Ambev.Unicesumar.Canteen.Domain.Users;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserAsync(string login, string password);
    }
}