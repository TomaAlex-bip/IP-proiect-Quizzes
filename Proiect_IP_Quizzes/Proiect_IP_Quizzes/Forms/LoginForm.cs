using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters.PresenterFactory;
using Presenters.Presenters;
using Utils.Interfaces;

namespace Proiect_IP_Quizzes.Forms
{
    public partial class LoginForm : Form, ILoginView
    {
        public delegate void OnRegisterEventHandler(object sender, EventArgs e);
        public event OnRegisterEventHandler OnRegisterEvent;

        protected LoginPresenter _presenter;

        public LoginForm()
        {
            InitializeComponent();
            SetPresenter(PresenterFactory.Instance.GetLoginPresenter(this));
        }

        
        public void OnLoginClick(object sender, EventArgs e)
        {
            var loginUsername = txt_username.Text;
            var loginPassword = txt_password.Text;

            var hash = loginPassword;
            _presenter.LoginUser(loginUsername,hash);
            
        }

        public void OnRegisterClick(object sender, EventArgs e)
        {
            OnRegisterEvent?.Invoke(this, e);
        }

        

        public void SetPresenter(LoginPresenter presenter)
        {
            _presenter = presenter;
        }

    }
}
