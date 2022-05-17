using Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Presenters.Presenters
{
    public class LoginPresenter
    {
        private ILoginView _view;
        private LoginModel _model;

        public LoginPresenter(ILoginView view, LoginModel model)
        {
            _view = view;
            _model = model;
        }

        public User LoginUser(string username, string hash)
        {
            return _model.LoginUser(username, hash);
        }
    }
}
