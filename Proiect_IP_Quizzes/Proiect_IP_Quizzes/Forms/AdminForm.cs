using Entities;
using Presenters.PresenterFactory;
using Presenters.Presenters;
using System.Collections.Generic;
using System.Windows.Forms;
using Utils.Interfaces;

namespace Proiect_IP_Quizzes.Forms
{
    public partial class AdminForm : Form, IAdminView
    {
        private AdminPresenter _presenter;
        private MainForm _mainForm;

        public AdminForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            SetPresenter(PresenterFactory.Instance.GetAdminPresenter(this));
            LoadData();
        }

        public void LoadData(List<Question> questions)
        {
            textBoxQuestions.Text = string.Empty;
            foreach (var question in questions)
            {
                textBoxQuestions.Text += question.ToString() + "\r\n";
            }
        }

        public void NotifyError(string message)
        {
            MessageBox.Show($"Error: {message}!");
        }

        public void NotifySuccess(string message)
        {
            MessageBox.Show($"Success: {message}!");
        }

        private void LoadData()
        {
            _presenter.LoadData();
        }

        private void SetPresenter(AdminPresenter presenter) => _presenter = presenter;

        private void btn_add_Click(object sender, System.EventArgs e)
        {
            var type = textBoxType.Text;
            var text = textBoxQuestionText.Text;
            var a1 = textBoxA1.Text;
            var a2 = textBoxA2.Text;
            var a3 = textBoxA3.Text;
            var ca = (int)numericUpDownCorrAns.Value;

            if(ca > 3 || ca < 1)
            {
                MessageBox.Show("Correct Answer invalid, trebuie sa fie intre 1 si 3!");
                return;
            }

            var question = new Question(0, type, text, a1, a2, a3, ca);
            _presenter.AddQuestion(question);
        }

        private void btn_update_Click(object sender, System.EventArgs e)
        {
            int id;
            try
            {
                id = int.Parse(textBoxQuestionId.Text);
            }
            catch
            {
                MessageBox.Show("id invalid!");
                return;
            }

            var type = textBoxType.Text;
            var text = textBoxQuestionText.Text;
            var a1 = textBoxA1.Text;
            var a2 = textBoxA2.Text;
            var a3 = textBoxA3.Text;
            var ca = (int)numericUpDownCorrAns.Value;

            if (ca > 3 || ca < 1)
            {
                MessageBox.Show("Correct Answer invalid, trebuie sa fie intre 1 si 3!");
                return;
            }

            var question = new Question(id, type, text, a1, a2, a3, ca);
            _presenter.AddQuestion(question);
        }

        private void btn_delete_Click(object sender, System.EventArgs e)
        {
            try
            {
                var id = int.Parse(textBoxQuestionId.Text);
                _presenter.DeleteQuestion(id);
            }
            catch
            {
                MessageBox.Show("Id invalid!");
            }

        }

        public void ClearFields()
        {
            textBoxQuestionId.Text = string.Empty;
            textBoxType.Text = string.Empty;
            textBoxQuestionText.Text = string.Empty;
            textBoxA1.Text = string.Empty;
            textBoxA2.Text = string.Empty;
            textBoxA3.Text = string.Empty;
            numericUpDownCorrAns.Value = 0;
        }

        
    }
}
