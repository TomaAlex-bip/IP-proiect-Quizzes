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
        }

        public void RegisterUser(User user)
        {
            
        }

        public void OpenRegisterPage()
        {
            _view.OpenRegisterForm();
        }

    }
}
