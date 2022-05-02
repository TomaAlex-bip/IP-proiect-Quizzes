using Entities;
using Models;
using Proiect_IP_Quizzes.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.Presenters
{
    public class UserPresenter
    {
        private UserForm _view;
        private UserModel _model;

        public UserPresenter(UserForm view, UserModel model)
        {
            _view = view;
            _model = model;
        }

        public Statistic GetUserStatistics(int userId) => _model.GetUserStatistics(userId);

        public List<string> GetQuestionTypes() => _model.GetQuestionTypes();

        public List<Attempt> GetUserAttempts(int userId) => _model.GetUserAttempts(userId);
    }
}
