using System;
using VideoFluentValidation.Models;

namespace VideoFluentValidation.Services
{
    public interface IUsersService
    {
        public User Create(User user);
    }
    
    public class UsersService : IUsersService
    {
        public User Create(User user)
        {
            user.Id = Guid.NewGuid();
            return user;
        }
    }
}