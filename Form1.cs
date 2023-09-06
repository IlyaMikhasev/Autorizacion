using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autorizacion
{
    public partial class Form1 : Form
    {
        private List<User> _users;
        public Form1()
        {
            InitializeComponent();
            _users = new List<User>();
            l_users.Text = "Пользователи\n";
        }

        private void b_addUser_Click(object sender, EventArgs e)
        {
            if (suitableLogin(tb_login.Text) && suitablePassword(mascktb_pass.Text)) {
                User user = new User(tb_login.Text, mascktb_pass.Text.GetHashCode());
                _users.Add(user);
            }
            outputUsers();
        }
        private void b_testrregistr_Click(object sender, EventArgs e) {
            var login = tb_login.Text;
            var pass = mascktb_pass.Text.GetHashCode();
            User user = new User(login, pass);
            foreach (User use in _users)
            {
                if (use.Name == user.Name && use.Password == user.Password)
                {
                    this.Text = $"вы вошли как {user.Name}";
                    return;
                }
                else
                    this.Text = "Несуществующий аккаунт";
            }
        }
        private bool suitableLogin(string login) {
            if (login.Length > 3)
                return true;
            else
                return false;
        }
        private bool suitablePassword(string passford) {
            if (passford.Length >= 4)
                return true;
            else
                return false;
        }
        private void outputUsers() {
            l_users.Text = "Пользователи\n";
            foreach (User user in _users)
            {
                l_users.Text += $"{user.Name}\t{user.Password}\n";
            }
        
        }
    }
}
