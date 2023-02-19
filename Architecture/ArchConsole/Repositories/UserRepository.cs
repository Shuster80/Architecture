using ArchConsole.Models;
using System;

namespace ArchConsole.Repositories
{
    internal class UserRepository
    {
        public User GetUser(int id)
        {
            return new User { Id = id, Name = "UserName", Email = "UserEmail", Password = "password" };
        }

        internal void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
