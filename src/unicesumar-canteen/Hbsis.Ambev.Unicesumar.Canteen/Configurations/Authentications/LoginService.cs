using Hbsis.Ambev.Unicesumar.Canteen.Domain.Users;
using Hbsis.Ambev.Unicesumar.Canteen.Infra.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Api.Configurations.Authentications
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public LoginService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        public async Task<string> GenerateTokenAsync(string login, string password)
        {
            var user = await _userRepository.GetUserAsync(login, password);

            return user == null
                ? string.Empty
                : await GenerateTokenAsync(user);
        }

        private Task<string> GenerateTokenAsync(User user)
        {
            var secret = _configuration.GetSection("Secret").Value;
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Name.ToString()),
                    new Claim(ClaimTypes.Role, user.Role.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Task.FromResult(tokenHandler.WriteToken(token));
        }
    }
}
