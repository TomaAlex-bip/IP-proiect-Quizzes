using Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.Presenters
{
    public class LoginPresenter
    {
        private LoginModel _model;

        public LoginPresenter(LoginModel model)
        {
            _model = model;
        }

        public User LoginUser(string username, string hash)
        {
            // TODO
        }
    }
}
