using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorizacion
{
    enum Roles { 
        Administrator,
        manager,
        user
    } 
    internal class User
    {
        private string _name;
        public string Name { get { return _name; } }
        private int _password;
        public int Password { get { return _password; } }
        private Roles _role;
        public Roles Role { get { return _role; }set { _role = value; } }
        public User(string name, int password,Roles role = Roles.user)
        {
            _name = name;
            _password = password;
            _role = role;
        }   
    }
}
