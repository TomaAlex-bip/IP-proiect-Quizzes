using Entities;
using Models;
using Utils.Interfaces;

namespace Presenters.Presenters
{
    public class QuizPresenter
    {
        private IQuizView _view;
        private QuizModel _model;
        private MainPresenter _mainPresenter;

        public QuizPresenter(IQuizView view, QuizModel model, MainPresenter mainPresenter)
        {
            _view = view;
            _model = model;
            _mainPresenter = mainPresenter;
        }

        public void GenerateRandomQuiz(string type, int size, out Question question, out int totalQuestions)
        {
            _model.GenerateRandomQuiz(type, size);
            question = _model.FirstQuestion;
            totalQuestions = _model.TotalQuestions;
        }

        public void NextQuestion(int answer)
        {
            _model.VerifyQuestionAnswer(answer);
            var question = _model.GetNextQuestion();

            if(question == null)
            {
                FinishQuiz();
                return;
            }

            _view.LoadQuestion(question);
            _view.UpdateQuestionIndex(_model.FinishedQuestions, _model.TotalQuestions);
        }

        public void FinishQuiz()
        {
            var totalQuestions = _model.TotalQuestions;
            var correctQuestions = _model.CorrectAnswers;
            _view.ShowQuizResults(correctQuestions, totalQuestions);
            _mainPresenter.OpenUserPage();
        }

    }
}
