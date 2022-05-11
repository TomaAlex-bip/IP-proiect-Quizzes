using Presenters.Presenters;
using Proiect_IP_Quizzes.Forms;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ModelFactory;

namespace Presenters.PresenterFactory
{
    public class PresenterFactory
    {
        private static PresenterFactory _instance;

        public static PresenterFactory Instance => _instance ?? (_instance = new PresenterFactory());

        public LoginPresenter GetLoginPresenter(LoginForm view) => new LoginPresenter(view, ModelFactory.Instance.GetLoginModel());

        public RegisterPresenter GetRegisterPresenter(RegisterForm view) => new RegisterPresenter(view, ModelFactory.Instance.GetRegisterModel());

        public UserPresenter GetUserPresenter(UserForm view) => new UserPresenter(view, ModelFactory.Instance.GetUserModel());

        public QuizPresenter GetQuizPresenter(QuizForm view) => new QuizPresenter(view, ModelFactory.Instance.GetQuizModel());

        public AdminPresenter GetAdminPresenter(AdminForm view) => new AdminPresenter(view, ModelFactory.Instance.GetAdminModel());

    }
}
