using Models;
using Proiect_IP_Quizzes.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.Presenters
{
    public class RegisterPresenter
    {
        private RegisterModel _model;
        private RegisterForm _view;

        public RegisterPresenter(RegisterForm view, RegisterModel model)
        {
            _view = view;
            _model = model;
        }

        public bool RegisterUser(string username, string hash)
        {
            return _model.RegisterUser(username, hash);
        }
    }
}
