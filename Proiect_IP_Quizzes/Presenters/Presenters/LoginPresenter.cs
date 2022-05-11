using Entities;
using Models;
using Proiect_IP_Quizzes.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.Presenters
{
    public class LoginPresenter
    {
        private LoginForm _view;
        private LoginModel _model;

        public LoginPresenter(LoginForm view, LoginModel model)
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
