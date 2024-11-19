using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public class UserService : IUserService
    {
        private readonly List<User> _users;
        private int _userIdCounter;
        public UserService()
        {
            _users = new List<User>();
            _userIdCounter = 1;
        }
        public User Register(string username, string password)
        {
            User user = new User(_userIdCounter++, username, password);
            _users.Add(user);
            return user;
        }
        public User Login(string username, string password)
        {
            return _users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
