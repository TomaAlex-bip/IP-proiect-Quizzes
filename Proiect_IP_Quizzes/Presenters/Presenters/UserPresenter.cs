using Entities;
using Models;
using System.Collections.Generic;
using Utils.Interfaces;

namespace Presenters.Presenters
{
    public class UserPresenter
    {
        private IUserView _view;
        private UserModel _model;
        private MainPresenter _mainPresenter;

        public UserPresenter(IUserView view, UserModel model, MainPresenter mainPresenter)
        {
            _view = view;
            _model = model;
            _mainPresenter = mainPresenter;
        }

        public void InitView()
        {
            var currentUser = _mainPresenter.GetCurrentUser();
            if (currentUser == null)
                return;

            var statistics = _model.GetUserStatistics(currentUser.Id);
            var attempts = _model.GetUserAttempts(currentUser.Id);
            var questionTypes = _model.GetQuestionTypes();

            // TODO: insert values in textboxes
        }

    }
}
