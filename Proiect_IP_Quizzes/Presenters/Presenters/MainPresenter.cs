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
            _view.OpenRegisterForm();
        }

        public void OpenLoginPage()
        {
            _view.OpenLoginForm();
        }

    }
}
