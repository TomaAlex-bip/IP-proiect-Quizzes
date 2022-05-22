using Entities;
using Models;
using Utils.Interfaces;

namespace Presenters.Presenters
{
    public class MainPresenter
    {
        private MainModel _model;
        private IMainView _view;

        public MainPresenter(IMainView view, MainModel model)
        {
            _model = model;
            _view = view;
        }

        public void LoginUser(User user)
        {
            _model.UpdateCurrentUser(user);
            _view.OpenUserForm();
        }

        public void LogoutUser()
        {
            if (_model.CurrentUser != null)
            {
                _model.UpdateCurrentUser(null);
                _view.NotifyLogoutUser();
            }
            else
            {
                _view.NotifyCantLogoutUser();
            }
            _view.OpenLoginForm();
        }

        public void RegisterUser()
        {
            _view.OpenLoginForm();
        }

        public void OpenRegisterPage()
        {//butonu din login de register
            _view.OpenRegisterForm();
        }

        public void OpenLoginPage()
        {//butonu din register de login
            if (GetCurrentUser() != null)
            {
                if (_view.NotifyAlreadyLoggedIn())
                {
                    _model.UpdateCurrentUser(null);
                    _view.OpenLoginForm();
                }
            }
            else _view.OpenLoginForm();
        }

        public User GetCurrentUser()
        {
            return _model.CurrentUser;
        }

    }
}
