using Presenters.PresenterFactory;
using Presenters.Presenters;
using System;
using System.Drawing;
using System.Windows.Forms;
using Utils.Interfaces;

namespace Proiect_IP_Quizzes
{
    public partial class MainForm : Form, IMainView
    {
        private MainPresenter _presenter;
        private Button _currentButton;
        private Form _currentForm;

        public MainPresenter Presenter => _presenter;

        public MainForm()
        {
            InitializeComponent();
            SetPresenter(PresenterFactory.Instance.GetMainPresenter(this));
        }

        private void ActivateButton(object btnSender) //modific culoarea si marimea scrisului din butonul selectat
        {
            if(btnSender != null)
            {
                if(_currentButton != (Button)btnSender)
                {
                    DisableButton();
                    _currentButton = (Button)btnSender;
                    _currentButton.BackColor = Color.Azure;
                    _currentButton.Font = new Font("David Libre", 17F, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, ((byte)0));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(_currentForm != null)
            {
                _currentForm.Close();
            }
            ActivateButton(btnSender);
            _currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(childForm);
            this.panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_title.Text = childForm.Text; //schimbam titlul din header

        }

        private void DisableButton() //aduc butonul inapoi la setarile initiale
        {
            foreach( Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Teal;
                    previousBtn.Font = new Font("David Libre", 15.75F, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, ((byte)0));
                }
            }
        }

        private void OpenLoginForm(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.LoginForm(this), sender);
        }

        public void OpenRegisterForm(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.RegisterForm(this), sender);
        }

        private void OpenUserForm(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.UserForm(this), sender);
        }

        private void OpenAdminForm(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminForm(), sender);
        }

        private void Logout(object sender, EventArgs e)
        {
            ActivateButton(sender);
            _presenter.LogoutUser();
        }

        private void SetPresenter(MainPresenter presenter)
        {
            _presenter = presenter;
        }

        public void OpenRegisterForm()
        {
            OpenRegisterForm(btn_register, null);
        }

        public void OpenLoginForm()
        {
            OpenLoginForm(btn_login, null);
        }

        public void NotifyLogoutUser()
        {
            MessageBox.Show("Te-ai delogat cu succes!");
        }

        public void OpenUserForm()
        {
            OpenUserForm(btn_user, null);
        }
    }
}
