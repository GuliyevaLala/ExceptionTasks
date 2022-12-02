using System;
using System.Collections.Generic;
using System.Text;

namespace Domaiin.BaseEntity {
    public class User {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Passcode { get; set; }


        public User(string username, string email, string passcode)
        {
            Username = username;
            Email = email;
            Passcode = passcode;
        }
    }
}
