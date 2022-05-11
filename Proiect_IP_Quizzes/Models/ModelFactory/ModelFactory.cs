using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelFactory
{
    public class ModelFactory
    {
        private static ModelFactory _instance;

        public static ModelFactory Instance { get { return _instance ?? (_instance = new ModelFactory()); } }

        public LoginModel GetLoginModel() => new LoginModel();

        public RegisterModel GetRegisterModel() => new RegisterModel();

        public UserModel GetUserModel() => new UserModel();

        public QuizModel GetQuizModel() => new QuizModel();

        public AdminModel GetAdminModel() => new AdminModel();

    }
}
