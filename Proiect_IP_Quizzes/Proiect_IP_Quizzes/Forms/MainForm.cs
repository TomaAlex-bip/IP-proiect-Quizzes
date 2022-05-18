using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters.Presenters;

namespace Proiect_IP_Quizzes
{
    public partial class MainForm : Form
    {
        private MainPresenter _presenter;
        private Button _currentButton;
        private Form _currentForm;
        public MainForm()
        {
            InitializeComponent();
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
            _currentForm = new Forms.LoginForm(this);
            OpenChildForm(new Forms.LoginForm(this), sender);
        }

        public void OpenRegisterForm(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.RegisterForm(), sender);
        }

        private void OpenUserForm(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.UserForm(), sender);
        }

        private void OpenAdminForm(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminForm(), sender);
        }

        private void Logout(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void SetPresenter(MainPresenter presenter)
        {
            _presenter = presenter;
        }
    }
}
