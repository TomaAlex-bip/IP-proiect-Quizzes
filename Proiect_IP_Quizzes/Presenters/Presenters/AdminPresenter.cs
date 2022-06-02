using Entities;
using Models;
using Persistence;
using Utils.Interfaces;

namespace Presenters.Presenters
{
    public class AdminPresenter
    {
        private IAdminView _view;
        private AdminModel _model;

        public AdminPresenter(IAdminView view, AdminModel model)
        {
            _view = view;
            _model = model;
        }

        public void AddQuestion(Question question)
        {
            var status = _model.AddQuestion(question);
            
            if(status == false)
            {
                _view.NotifyError("can't add question");
            }
            else
            {
                _view.NotifySuccess("added question!");
                _view.ClearFields();
            }
            
        }

        public void UpdateQuestion(int id, Question question)
        {
            var status = _model.UpdateQuestion(id, question);
            if (status == false)
            {
                _view.NotifyError("can't update question");
            }
            else
            {
                _view.NotifySuccess($"updated question with id: {id}");
                _view.ClearFields();
            }
        }

        public void DeleteQuestion(int id)
        {
            var status = _model.DeleteQuestion(id);
            if( status == false)
            {
                _view.NotifyError("can't delete question");
            }
            else
            {
                _view.NotifySuccess($"deleted question with id: {id}");
                _view.ClearFields();
            }
        }

        public void LoadData()
        {
            var questions = DatabaseContext.Instance.GetAllQuestions();
            _view.LoadData(questions);
        }

    }
}
