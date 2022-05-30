using Presenters.PresenterFactory;
using Presenters.Presenters;
using System;
using System.Windows.Forms;
using Utils.Interfaces;

namespace Proiect_IP_Quizzes.Forms
{
    public partial class QuizForm : Form, IQuizView
    {
        private QuizPresenter _presenter;
        private MainForm _mainForm;

        public QuizForm(MainForm mainForm, string type, int size)
        {
            InitializeComponent();
            _mainForm = mainForm;
            SetPresenter(PresenterFactory.Instance.GetQuizPresenter(this));
            LoadData(type, size);
        }

        private void LoadData(string type, int size)
        {
            _presenter.GenerateRandomQuiz(type, size);
        }

        private void OnNextQuestionClick(object sender, EventArgs e)
        {
            var answer = 0; // TODO: get the actual answer
            _presenter.NextQuestion(answer);
        }

        private void SetPresenter(QuizPresenter presenter) => _presenter = presenter;
    }
}
