using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoochWareHouse_Automation.Pages;

namespace PoochWareHouse_Automation.Configuration
{
    public class LoginConfiguration
    {
        public string UserName;
        public string Password;

        public LoginConfiguration ValidCredentials()
        {
            return new LoginConfiguration
            {
                UserName = "grgreatrex@hotmail.com",
                Password = "Test001",
            };
        }

        public LoginConfiguration InvalidEmailFormat()
        {
            return new LoginConfiguration
            {
                UserName = "grgreatrex",
                Password = "Test001"
            };
        }

        public LoginConfiguration IncorrectPassword()
        {
            return new LoginConfiguration
            {
                UserName = "grgreatrex@hotmail.com",
                Password = "Test002"
            };
        }

        public LoginConfiguration EmailNotRegistered()
        {
            return new LoginConfiguration
            {
                UserName = "grgreatrex@hotmail.co.uk",
                Password = "Test001"
            };
        }
    }
}