using Presenters.PresenterFactory;
using Presenters.Presenters;
using System;
using System.Windows.Forms;
using Utils;
using Utils.Interfaces;

namespace Proiect_IP_Quizzes.Forms
{
    public partial class RegisterForm : Form, IRegisterView
    {
        private RegisterPresenter _presenter;
        private MainForm _mainForm;

        public RegisterForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            SetPresenter(PresenterFactory.Instance.GetRegisterPresenter(this, _mainForm.Presenter));
        }

        private void OnRegisterClick(object sender, EventArgs e)
        {
            var registerUsername = txt_username.Text;
            var registerPassword = txt_password.Text;
            var confirmPassword = txt_confirmPassword.Text;

            if (registerPassword != confirmPassword)
            {
                MessageBox.Show("Parolele cu coincid");
                return;
            }

            var hash = Cryptography.HashString(registerPassword);

            _presenter.RegisterUser(registerUsername, hash);
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            _presenter.OpenLoginPage();
        }

        private void SetPresenter(RegisterPresenter presenter)
        {
            _presenter = presenter;
        }

        public void RegisterFailed(string username)
        {
            MessageBox.Show($"Inregistrarea a esuat pentru username: {username}");
        }

        public void RegisterSucceeded(string username)
        {
            MessageBox.Show($"Inregistrare efectuata pentru user: {username}");
        }
    }
}
