
namespace Models.ModelFactory
{
    public class ModelFactory
    {
        private static ModelFactory _instance;

        private static MainModel _mainModelInstance;

        public static ModelFactory Instance { get { return _instance ?? (_instance = new ModelFactory()); } }

        public LoginModel GetLoginModel() => new LoginModel();

        public RegisterModel GetRegisterModel() => new RegisterModel();

        public UserModel GetUserModel() => new UserModel();

        public QuizModel GetQuizModel() => new QuizModel();

        public AdminModel GetAdminModel() => new AdminModel();

        public MainModel GetMainModel()
        {
            if (_mainModelInstance == null)
            {
                _mainModelInstance = new MainModel();
            }

            return _mainModelInstance;
        }
    }
}
