using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat
{
    public enum UserRole{ Visitor, Admin }
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public UserRole Role { get; set; }

        public User() { }
        public User(string username, string password, UserRole role) { 
            this.Username = username;
            this.Password = password;   
            this.Role = role;
        }
    }
}
