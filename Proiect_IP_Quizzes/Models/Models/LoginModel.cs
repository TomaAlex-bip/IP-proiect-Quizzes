using Entities;
using Persistence;

namespace Models
{
    public class LoginModel
    {

        public User VerifyUser(string username, string hash)
        {
            return new User(1, "gigel", "1234", 0); // doar pentru testare
            return DatabaseContext.Instance.LoginUser(username, hash);
        }


    }
}
