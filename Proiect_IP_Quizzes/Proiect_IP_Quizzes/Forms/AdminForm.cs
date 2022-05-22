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
using System;
using System.Windows.Forms;
using Utils;
using Utils.Interfaces;

namespace Proiect_IP_Quizzes.Forms
{
    public partial class AdminForm : Form, IAdminView
    {
        private AdminPresenter _presenter;
        private MainForm _mainForm;
        public AdminForm(MainForm mainForm)
        {
            /*InitializeComponent();
            _mainForm = mainForm;
            SetPresenter(PresenterFactory.Instance.GetAdminPresenter(this, _mainForm.Presenter));
            _presenter.InitView();*/

            if (PresenterFactory.Instance.GetAdminPresenter(this, mainForm.Presenter).VerifyLogin())
            {
                if (PresenterFactory.Instance.GetAdminPresenter(this, mainForm.Presenter).VerifyAdmin())
                {
                    InitializeComponent();
                    _mainForm = mainForm;
                    SetPresenter(PresenterFactory.Instance.GetAdminPresenter(this, _mainForm.Presenter));
                    _presenter.InitView();
                }
                else
                {
                    NotifyNotAnAdmin();
                }
            }
            else
            {
                NotifyNotLoggedIn();
            }
        }

        public void NotifyNotAnAdmin()
        {
            MessageBox.Show("Nu sunteti admin.", "Atentie!");
        }
        public void NotifyNotLoggedIn()
        {
            MessageBox.Show("Nu sunteti logat.", "Atentie!");
        }

        private void SetPresenter(AdminPresenter presenter)
        {
            _presenter = presenter;
        }

        public void WelcomeLabelAdmin(string username)
        {
            lbl_welcome.Text = "Welcome " + username;
        }
    }
}
