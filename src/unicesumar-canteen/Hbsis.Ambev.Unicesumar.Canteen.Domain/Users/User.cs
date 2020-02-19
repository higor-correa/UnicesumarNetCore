﻿using System;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Users
{
    public class User : BaseEntity
    {
        public User(Guid id, string login, string password, string role)
        {
            Id = id;
            Login = login;
            Password = password;
            Role = role;
        }

        public string Login { get; protected set; }
        public string Password { get; protected set; }
        public string Role { get; protected set; }
    }
}
