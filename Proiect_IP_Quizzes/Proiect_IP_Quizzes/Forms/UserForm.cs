using Presenters.PresenterFactory;
using Presenters.Presenters;
using System.Collections.Generic;
using System.Windows.Forms;
using Utils.Interfaces;

namespace Proiect_IP_Quizzes.Forms
{
    public partial class UserForm : Form, IUserView
    {
        private UserPresenter _presenter;
        private MainForm _mainForm;

        public UserForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            SetPresenter(PresenterFactory.Instance.GetUserPresenter(this, _mainForm.Presenter));
            LoadData();
        }

        public void LoadData(int attempted, int passed, int failed, List<string> history, List<string> types)
        {
            labelAttemptedQuizzes.Text = attempted.ToString();
            labelPassedQuizzes.Text = passed.ToString();
            labelFailedQuizzes.Text = failed.ToString();

            textBoxAttemptsHistory.Text = string.Empty;
            foreach(var attempts in history)
            {
                textBoxAttemptsHistory.Text += attempts + "\r\n";
            }

            comboBoxType.Items.Clear();
            foreach(var type in types)
            {
                comboBoxType.Items.Add(type);
            }
        }


        private void buttonStartQuiz_Click(object sender, System.EventArgs e)
        {
            var type = comboBoxType.SelectedText;
            var size = (int)numericUpDownNoQuestions.Value;
            _presenter.StartQuiz(type, size);
        }

        private void LoadData()
        {
            _presenter.LoadData();
        }

        private void SetPresenter(UserPresenter presenter) => _presenter = presenter;
    }
}
