using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Testing.Pages
{
    public interface ILogin
    {
         void Login(string username, string password);
         void ClickOnSignUp();
        void ClickOnResetPassword();
       
    }
}
