using Presenters.PresenterFactory;
using Presenters.Presenters;
using System;
using System.Windows.Forms;
using Utils;
using Utils.Interfaces;

namespace Proiect_IP_Quizzes.Forms
{
    public partial class LoginForm : Form, ILoginView
    {
        private LoginPresenter _presenter;
        private MainForm _mainForm;

        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            SetPresenter(PresenterFactory.Instance.GetLoginPresenter(this, _mainForm.Presenter));
        }

        public void LoginFailed(string username)
        {
            MessageBox.Show("Username si parola incorecte!");
        }

        public void LoginSucceeded(string username)
        {
            MessageBox.Show($"Logat cu succes ca user: {username}");
        }

        public void OnLoginClick(object sender, EventArgs e)
        {
            var loginUsername = txt_username.Text;
            var loginPassword = txt_password.Text;

            var hash = Cryptography.HashString(loginPassword);

            _presenter.LoginUser(loginUsername, hash);
        }

        public void OnRegisterClick(object sender, EventArgs e)
        {
            _presenter.OpenRegisterPage();
        }

        public void SetPresenter(LoginPresenter presenter)
        {
            _presenter = presenter;
        }

    }
}
