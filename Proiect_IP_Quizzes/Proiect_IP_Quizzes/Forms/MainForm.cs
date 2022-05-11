using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_IP_Quizzes
{
    public partial class MainForm : Form
    {
        private Button _currentButton;
        private Form _activeForm;
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
            if(_activeForm != null)
            {
                _activeForm.Close();
            }
            ActivateButton(btnSender);
            _activeForm = childForm;
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.LoginForm(),sender);
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.RegisterForm(), sender);
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.UserForm(), sender);
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminForm(), sender);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
