using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Api.Configurations.Authentications
{
    public interface ILoginService
    {
        Task<string> GenerateTokenAsync(string login, string password);
    }
}