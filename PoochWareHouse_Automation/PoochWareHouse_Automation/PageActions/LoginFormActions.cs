using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoochWareHouse_Automation.Navigation;
using PoochWareHouse_Automation.Pages;

namespace PoochWareHouse_Automation.PageActions
{
    public class LoginFormActions
    {
        public void LoginUserAccount(string userName, string password)
        {
            Login.CompleteUserNameField(userName);
            Login.CompletePasswordField(password);
            Login.ClickLoginButton();
        }
    }
}
