using Models;
using System.Collections.Generic;
using System.Linq;
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

        public void LoadData()
        {
            var user = _mainPresenter.CurrentUser;
            //if (user == null)
            {
                _view.LoadData(0, 0, 0, new List<string>(), new List<string>());
                return;
            }

            var stats = _model.GetUserStatistics(user.Id);
            var history = _model.GetUserAttempts(user.Id);
            var historyString = (from attempt in history
                                 select attempt.ToString()).ToList();
            var types = _model.GetQuestionTypes();

            _view.LoadData(stats.TestsSubmitted, stats.TestsPassed, stats.TestsFailed, historyString, types);
        }

        public void StartQuiz(string type, int size)
        {
            _mainPresenter.OpenQuizPage(type, size);
        }

    }
}
