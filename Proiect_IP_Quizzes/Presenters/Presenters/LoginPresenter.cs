using Models;
using Utils.Interfaces;

namespace Presenters.Presenters
{
    public class LoginPresenter
    {
        private ILoginView _view;
        private LoginModel _model;
        private MainPresenter _mainPresenter;

        public LoginPresenter(ILoginView view, LoginModel model, MainPresenter mainPresenter)
        {
            _view = view;
            _model = model;
            _mainPresenter = mainPresenter;
        }

        public void LoginUser(string username, string hash)
        {
            var user = _model.VerifyUser(username, hash);
            
            if(user == null)
            {
                _view.LoginFailed(username);
            }
            else
            {
                _view.LoginSucceeded(user.Username);
                _mainPresenter.LoginUser(user);
            }
        }

        public void OpenRegisterPage()
        {
            _mainPresenter.OpenRegisterPage();
        }
    }
}
