using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Presenters.Presenters
{
    public class RegisterPresenter
    {
        private RegisterModel _model;
        private IRegisterView _view;

        public RegisterPresenter(IRegisterView view, RegisterModel model)
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
