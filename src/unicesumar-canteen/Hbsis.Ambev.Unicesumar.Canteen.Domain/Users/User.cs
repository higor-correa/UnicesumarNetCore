using System;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Users
{
    public class User : BaseEntity
    {
        public User(Guid id, string login, string name, string password, string role)
        {
            Id = id;
            Login = login;
            Name = name;
            Password = password;
            Role = role;
        }

        public string Login { get; protected set; }
        public string Name { get; set; }
        public string Password { get; protected set; }
        public string Role { get; protected set; }
    }
}
