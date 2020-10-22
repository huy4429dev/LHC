using DVN.Extension;
using DVN.Models;
using Microsoft.AspNetCore.Http;

namespace DVN.Services
{
    public class UserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public User IsUserLoggedIn()
        {
            var user = _httpContextAccessor.HttpContext.Session.Get<User>("user");
            return user;
        }
    }
}