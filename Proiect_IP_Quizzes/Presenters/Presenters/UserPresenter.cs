using Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Presenters.Presenters
{
    public class UserPresenter
    {
        private IUserView _view;
        private UserModel _model;

        public UserPresenter(IUserView view, UserModel model)
        {
            _view = view;
            _model = model;
        }

        public Statistic GetUserStatistics(int userId) => _model.GetUserStatistics(userId);

        public List<string> GetQuestionTypes() => _model.GetQuestionTypes();

        public List<Attempt> GetUserAttempts(int userId) => _model.GetUserAttempts(userId);
    }
}
