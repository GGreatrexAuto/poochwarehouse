using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoochWareHouse_Automation.Configuration
{
    public class CreateAccountConfiguration
    {
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public string Password;

        public CreateAccountConfiguration ValidPassword()
        {
            return new CreateAccountConfiguration
            {
                Password = "Test1"
            };
        }

        public CreateAccountConfiguration ValidEmail()
        {
            return new CreateAccountConfiguration
            {
                EmailAddress = "gareth@hotmail.com"
            };
        }

        public CreateAccountConfiguration ExistingAccount()
        {
            return new CreateAccountConfiguration
            {
                EmailAddress = "grgreatrex@hotmail.com"
            };
        }

        public CreateAccountConfiguration PasswordTooShort()
        {
            return new CreateAccountConfiguration
            {
                Password = "Test"
            };
        }

        public CreateAccountConfiguration InvalidEmailFormat()
        {
            return new CreateAccountConfiguration
            {
                EmailAddress = "g"
            };
        }
    }
}
