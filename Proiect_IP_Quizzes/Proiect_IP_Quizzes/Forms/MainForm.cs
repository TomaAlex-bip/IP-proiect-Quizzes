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
            UpdateActiveButtons();
        }

        public void OpenRegisterForm()
        {
            OpenChildForm(new Forms.RegisterForm(this), btn_register);
        }

        public void OpenLoginForm()
        {
            OpenChildForm(new Forms.LoginForm(this), btn_login);
        }

        public void NotifyLogoutUser()
        {
            MessageBox.Show("Te-ai delogat cu succes!");
        }

        public void OpenUserForm()
        {
            OpenChildForm(new Forms.UserForm(), btn_user);
        }

        public void OpenAdminForm()
        {
            OpenChildForm(new Forms.AdminForm(), btn_admin);
        }

        public void NotifyNotLoggedIn()
        {
            MessageBox.Show("Nu esti logat!");
        }

        public void NotifyRestrictedPermission()
        {
            MessageBox.Show("Nu ai permisiune pentru acest meniu!");
        }

        public void OpenRegisterForm(object sender, EventArgs e)
        {
            _presenter.OpenRegisterPage();
        }

        public void NotifyAlreadyLoggedIn()
        {
            MessageBox.Show("Esti deja logat!");
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

            UpdateActiveButtons();
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
            _presenter.OpenLoginPage();
        }

        private void OpenUserForm(object sender, EventArgs e)
        {
            _presenter.OpenUserPage();
        }

        private void OpenAdminForm(object sender, EventArgs e)
        {
            _presenter.OpenAdminPage();
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

        private void UpdateActiveButtons()
        {
            if (_presenter.IsLoggedIn)
            {
                btn_login.Enabled = false;
                btn_register.Enabled = false;
                btn_logout.Enabled = true;

                if (_presenter.IsAdmin)
                {
                    btn_user.Enabled = false;
                    btn_admin.Enabled = true;
                }
                else
                {
                    btn_user.Enabled = true;
                    btn_admin.Enabled = false;
                }
            }
            else
            {
                btn_login.Enabled = true;
                btn_register.Enabled = true;
                btn_user.Enabled = false;
                btn_admin.Enabled = false;
                btn_logout.Enabled = false;
            }
        }
    }
}
