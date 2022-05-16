using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string Username { get; private set; }
        public string Hash { get; private set; }
        public int IsAdmin { get; private set; }

        public User(int id, string username, string hash, int isAdmin)
        {
            Id = id;
            Username = username;
            Hash = hash;
            IsAdmin = isAdmin;
        }
    }
}
