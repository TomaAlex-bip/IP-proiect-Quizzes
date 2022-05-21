using Entities;

namespace Models
{
    public class MainModel
    {
        public User CurrentUser => _currentUser;

        private User _currentUser;

        public MainModel()
        {
            _currentUser = null;
        }

        public void UpdateCurrentUser(User user) => _currentUser = user;

    }
}
