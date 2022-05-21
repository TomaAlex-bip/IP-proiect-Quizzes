using Persistence;

namespace Models
{
    public class RegisterModel
    {

        public RegisterModel()
        {

        }

        public bool RegisterUser(string username, string hash)
        {
            return true;
            return DatabaseContext.Instance.RegisterUser(username, hash);
        }
    }
}
