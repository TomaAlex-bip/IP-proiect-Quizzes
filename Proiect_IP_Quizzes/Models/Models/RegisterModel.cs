using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RegisterModel
    {

        public RegisterModel()
        {

        }

        public bool RegisterUser(string username, string hash)
        {
            return DatabaseContext.GetInstance.RegisterUser(username, hash);
        }
    }
}
