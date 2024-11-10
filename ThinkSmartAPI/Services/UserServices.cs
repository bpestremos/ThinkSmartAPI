using ThinkSmartAPI.Interfaces;
using ThinkSmartAPI.Models;

namespace ThinkSmartAPI.Services
{
    public class UserServices : UsersInterface
    {
        private readonly AppDBContext _context;
        public UserServices(AppDBContext context)
        {
            _context = context;
        }


        public List<Users> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
