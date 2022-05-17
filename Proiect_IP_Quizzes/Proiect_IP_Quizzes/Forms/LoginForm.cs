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

namespace Proiect_IP_Quizzes.Forms
{
    public partial class LoginForm : Form
    {
        protected LoginPresenter _presenter;
        public LoginForm()
        {
            InitializeComponent();
        }
        

        public void OnLoginClick(object sender, EventArgs e)
        {

        }

        public void OnRegisterClick(object sender, EventArgs e)
        {

        }

        //public void SetPresenter(LoginPresenter presenter)

    }
}
