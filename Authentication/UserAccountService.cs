/*
namespace BlazorServerAuthenticationAndAuthorization.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;

        public UserAccountService()
        {
            _users = new List<UserAccount>
            {
                new UserAccount{ UserName = "admin", Password = "admin", Role = "Administrator" },
                new UserAccount{ UserName = "user", Password = "user", Role = "User" }
            };
        }

        public UserAccount? GetByUserName(string userName)
        {
            return _users.FirstOrDefault(x => x.UserName == userName);
        }
    }
}
*/
using BlazorAppProjekt.Data;
using BlazorAppProjekt.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlazorServerAuthenticationAndAuthorization.Authentication
{
    public class UserAccountService
    {
        private readonly MyDbContext _dbContext;

        public UserAccountService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UserAccount? GetByUserName(string userName)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.UserName == userName);
            if (user == null)
            {
                return null;
            }
            return new UserAccount { UserName = user.UserName, Password = user.Password, Role = user.userlevel };
        }
    }
}
