using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.domain.repository
{
    interface AuthenticationRepository
    {
        string Login(string username, string password);
        string Register(string name, string username, string password);
    }
}
