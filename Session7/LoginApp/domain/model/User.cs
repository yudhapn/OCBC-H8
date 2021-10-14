using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.domain
{
    class User
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _username;
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _password;
        
        public User()
        {
            name = "Yudha Pratama";
            _username = "ypran";
            _password = "yudha";
        }
        public bool Login(string username, string password)
        {
            return username == this._username && password == this._password;
        }
    }
}
