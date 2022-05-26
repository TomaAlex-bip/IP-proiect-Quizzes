using Models;
using Utils.Interfaces;

namespace Presenters.Presenters
{
    public class RegisterPresenter
    {
        private RegisterModel _model;
        private IRegisterView _view;
        private MainPresenter _mainPresenter;

        public RegisterPresenter(IRegisterView view, RegisterModel model, MainPresenter mainPresenter)
        {
            _view = view;
            _model = model;
            _mainPresenter = mainPresenter;
        }

        public void RegisterUser(string username, string hash)
        {
            var status = _model.RegisterUser(username, hash);
            if (status == false)
            {
                _view.RegisterFailed(username);
            }
            else
            {
                _view.RegisterSucceeded(username);
                _mainPresenter.RegisterUser();
            }
        }

        public void OpenLoginPage()
        {
            _mainPresenter.OpenLoginPage();
        }
    }
}
