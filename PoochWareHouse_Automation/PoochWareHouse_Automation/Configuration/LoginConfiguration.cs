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
        public string UserName = "grgreatrex@hotmail.com";
        public string Password = "Test001";

        public LoginConfiguration ValidCredentials()
        {
            return new LoginConfiguration
            {
                UserName = "grgreatrex@hotmail.com",
                Password = "Test001",
            };
        }

    }
}
