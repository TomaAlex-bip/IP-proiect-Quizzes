using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
