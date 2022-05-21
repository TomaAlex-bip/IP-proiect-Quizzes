using Entities;

namespace Models
{
    public class MainModel
    {

        private User _currentUser;

        public MainModel()
        {
            _currentUser = null;
        }

        public void UpdateCurrentUser(User user) => _currentUser = user;

    }
}
