using Entities;
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
            SetPresenter(PresenterFactory.Instance.GetQuizPresenter(this, _mainForm.Presenter));
            LoadData(type, size);
        }

        public void LoadQuestion(Question question)
        {
            lbl_questionText.Text = question.Text;
            radiobtn_first.Text = question.Answer1;
            radiobtn_second.Text = question.Answer2;
            radiobtn_third.Text = question.Answer3;

            radiobtn_first.Checked = false;
            radiobtn_second.Checked = false;
            radiobtn_third.Checked = false;
        }

        public void UpdateQuestionIndex(int currentIndex, int totalQuestions)
        {
            lbl_questionNumber.Text = $"{currentIndex+1}/{totalQuestions}";
        }

        public void ShowQuizResults(int correntAnswers, int totalQuestions)
        {
            MessageBox.Show($"Ai raspuns corect la {correntAnswers} din {totalQuestions}");
        }

        private void LoadData(string type, int size)
        {
            _presenter.GenerateRandomQuiz(type, size, out var question, out var totalQuestions);
            LoadQuestion(question);
            UpdateQuestionIndex(0, totalQuestions);
        }

        private void OnNextQuestionClick(object sender, EventArgs e)
        {
            var answer = 0;

            if(radiobtn_first.Checked)
                answer = 1;

            if (radiobtn_second.Checked)
                answer = 2;

            if (radiobtn_third.Checked)
                answer = 3;

            _presenter.NextQuestion(answer);
        }

        private void SetPresenter(QuizPresenter presenter) => _presenter = presenter;
    }
}
