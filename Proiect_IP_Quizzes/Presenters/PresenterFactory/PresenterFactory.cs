using Presenters.Presenters;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ModelFactory;
using Utils.Interfaces;

namespace Presenters.PresenterFactory
{
    public class PresenterFactory
    {
        private static PresenterFactory _instance;

        public static PresenterFactory Instance => _instance ?? (_instance = new PresenterFactory());

        public LoginPresenter GetLoginPresenter(ILoginView view) => new LoginPresenter(view, ModelFactory.Instance.GetLoginModel());

        public RegisterPresenter GetRegisterPresenter(IRegisterView view) => new RegisterPresenter(view, ModelFactory.Instance.GetRegisterModel());

        public UserPresenter GetUserPresenter(IUserView view) => new UserPresenter(view, ModelFactory.Instance.GetUserModel());

        public QuizPresenter GetQuizPresenter(IQuizView view) => new QuizPresenter(view, ModelFactory.Instance.GetQuizModel());

        public AdminPresenter GetAdminPresenter(IAdminView view) => new AdminPresenter(view, ModelFactory.Instance.GetAdminModel());

    }
}
