using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public interface IUserService
    {
        User Register(string username, string password);
        User Login(string username, string password);
    }
}
