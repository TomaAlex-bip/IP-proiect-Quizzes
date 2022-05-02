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
    public class AdminPresenter
    {

        private AdminForm _view;
        private AdminModel _model;

        public AdminPresenter(AdminForm view, AdminModel model)
        {
            _view = view;
            _model = model;
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

    }
}
