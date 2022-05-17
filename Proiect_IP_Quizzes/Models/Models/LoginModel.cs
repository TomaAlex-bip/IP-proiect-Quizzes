using Entities;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LoginModel
    {

        public LoginModel()
        {

        }

        public User LoginUser(string username, string hash)
        {
            return DatabaseContext.Instance.LoginUser(username, hash);
        }
    }
}
