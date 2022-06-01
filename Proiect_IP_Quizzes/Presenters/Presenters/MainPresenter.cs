using Entities;
using Models;
using Utils.Interfaces;

namespace Presenters.Presenters
{
    public class MainPresenter
    {
        public User CurrentUser => _model.CurrentUser;
        public bool IsLoggedIn { get => _model.CurrentUser != null; }
        public bool IsAdmin 
        { 
            get
            {
                if(_model.CurrentUser != null && _model.CurrentUser.IsAdmin == 1)
                {
                    return true;
                }
                return false;
            } 
        }

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

            var loggedUser = _model.CurrentUser;

            if (loggedUser == null)
            {
                _view.NotifyNotLoggedIn();
                return;
            }

            if (loggedUser.IsAdmin == 0)
            {
                _view.OpenUserForm();
            }
            else if(loggedUser.IsAdmin == 1)
            {
                _view.OpenAdminForm();
            }
        }

        public void LogoutUser()
        {
            var user = _model.CurrentUser;
            if (user == null)
            {
                _view.NotifyNotLoggedIn();
                return;
            }

            _model.UpdateCurrentUser(null);
            _view.NotifyLogoutUser();
            _view.OpenLoginForm();
        }

        public void RegisterUser()
        {
            _view.OpenLoginForm();
        }

        public void OpenRegisterPage()
        {
            var user = _model.CurrentUser;
            if(user != null)
            {
                _view.NotifyAlreadyLoggedIn();
                return;
            }

            _view.OpenRegisterForm();
        }

        public void OpenLoginPage()
        {
            var user = _model.CurrentUser;
            if (user != null)
            {
                _view.NotifyAlreadyLoggedIn();
                return;
            }

            _view.OpenLoginForm();
        }

        public void OpenUserPage()
        {
            var user = _model.CurrentUser;

            if (user == null)
            {
                _view.NotifyNotLoggedIn();
                return;
            }

            if(user.IsAdmin == 0)
            {
                _view.OpenUserForm();
            }
            else
            {
                _view.NotifyRestrictedPermission();
            }
        }

        public void OpenAdminPage()
        {
            var user = _model.CurrentUser;

            if (user == null)
            {
                _view.NotifyNotLoggedIn();
                return;
            }

            if (user.IsAdmin == 1)
            {
                _view.OpenAdminForm();
            }
            else
            {
                _view.NotifyRestrictedPermission();
            }
        }

        public void OpenQuizPage(string type, int size)
        {
            _view.OpenQuizForm(type, size);
        }

    }
}
