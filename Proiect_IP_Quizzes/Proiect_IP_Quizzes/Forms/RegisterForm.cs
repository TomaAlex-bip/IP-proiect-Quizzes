using Entities;
using Presenters.PresenterFactory;
using Presenters.Presenters;
using System;
using System.Windows.Forms;
using Utils.Interfaces;

namespace Proiect_IP_Quizzes.Forms
{
    public partial class RegisterForm : Form, IRegisterView
    {
        public delegate void OnRegisterEventHandler(User user);
        public event OnRegisterEventHandler OnRegisterEvent;

        public delegate void OnLoginEventHandler();
        public event OnLoginEventHandler OnLoginEvent;

        protected RegisterPresenter _presenter;

        public RegisterForm()
        {
            InitializeComponent();
            SetPresenter(PresenterFactory.Instance.GetRegisterPresenter(this));
        }

        private void OnRegisterClick(object sender, EventArgs e)
        {
            var user = new User(1, "dorel", "qwerty", 0);
            OnRegisterEvent?.Invoke(user);
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            OnLoginEvent?.Invoke();
        }

        private void SetPresenter(RegisterPresenter presenter)
        {
            _presenter = presenter;
        }
    }
}
