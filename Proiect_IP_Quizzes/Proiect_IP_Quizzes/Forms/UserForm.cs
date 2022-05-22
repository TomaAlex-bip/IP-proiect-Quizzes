using Presenters.PresenterFactory;
using Presenters.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //InitializeComponent();
            if (PresenterFactory.Instance.GetUserPresenter(this, mainForm.Presenter).VerifyLogin())
            {
                InitializeComponent();
                _mainForm = mainForm;
                SetPresenter(PresenterFactory.Instance.GetUserPresenter(this, _mainForm.Presenter));
                _presenter.InitView();
            }
            else
            {
                NotifyNotLoggedIn();
            }
            //SetPresenter(PresenterFactory.Instance.GetUserPresenter(this, _mainForm.Presenter));  
        }

        public void NotifyNotLoggedIn()
        {
            MessageBox.Show("Nu sunteti logat.", "Atentie!");
        }

        private void SetPresenter(UserPresenter presenter)
        {
            _presenter = presenter;
        }

        public void WelcomeLabelUsername(string Username)
        {
            lbl_user_name.Text = Username;
        }
    }
}
