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
    public class AdminPresenter
    {

        private IAdminView _view;
        private AdminModel _model;
        private MainPresenter _mainPresenter;

        public AdminPresenter(IAdminView view, AdminModel model, MainPresenter mainPresenter)
        {
            _view = view;
            _model = model;
            _mainPresenter = mainPresenter;
        }

        public void AddQuestion(Question question)
        {
            _model.AddQuestion(question);
            //TODO: call method from view to clear the fields or to notify user for mistake
        }

        public void UpdateQuestion(int id, Question question)
        {
            _model.UpdateQuestion(id, question);
            //TODO: call method from view to clear the fields or to notify user for mistake
        }

        public void DeleteQuestion(int id)
        {
            _model.DeleteQuestion(id);
            //TODO: call method from view to clear the fields or to notify user for mistake
        }

        public List<Question> GetAllQuestions()
        {
            return _model.GetAllQuestions();
        }

        public void InitView()
        {
            var currentUser = _mainPresenter.GetCurrentUser();
            if (currentUser == null)
                return;
            _view.WelcomeLabelAdmin(currentUser.Username);
            //lbl_welcome;
            // TODO: insert values in textboxes
        }

        public bool VerifyLogin()
        {
            if (_mainPresenter.GetCurrentUser() == null)
                return false;
            return true;
        }

        public bool VerifyAdmin()
        {
            //Pentru moment pentru test!
            if (_mainPresenter.GetCurrentUser().Username != "gigel")
                return false;
            return true;
        }

    }
}
