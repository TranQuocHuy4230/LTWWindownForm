using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF
{
    class Account
    {
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Account() { }
        public Account(string name,string username, string password)
        {
            this.DisplayName = name;
            this.UserName = username;
            this.Password = password;
        }

    }
}
