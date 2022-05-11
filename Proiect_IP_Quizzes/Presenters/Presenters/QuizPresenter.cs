using Models;
using Proiect_IP_Quizzes.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.Presenters
{
    public class QuizPresenter
    {
        private QuizForm _view;
        private QuizModel _model;

        public QuizPresenter(QuizForm view, QuizModel model)
        {
            _view = view;
            _model = model;
        }

        public void GenerateRandomQuiz(string type, int size)
        {
            _model.GenerateRandomQuiz(type, size);
        }

        public void NextQuestion(int answer)
        {
            _model.VerifyQuestionAnswer(answer);
            var question = _model.GetNextQuestion();
            // TODO: call function from view to display question
            _view.SetNextQuestion(question);
        }

        public void FinishQuiz()
        {
            // TODO: call method from model to register attempt
            // and then call method from view to change the form
        }

    }
}
