using Hbsis.Ambev.Unicesumar.Canteen.Domain.Users;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DbContext dbContext) : base(dbContext) { }

        public async Task<User> GetUserAsync(string login, string password) =>
            await DbSet.FirstOrDefaultAsync(x => x.Login == login && x.Password == password);
    }
}
