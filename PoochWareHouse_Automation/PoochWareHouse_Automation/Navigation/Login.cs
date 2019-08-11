using PoochWareHouse_Automation.Pages;

namespace PoochWareHouse_Automation.Navigation
{
    public static class Login
    {
        public static void ClickCreateAccount()
        {
            LoginForm.CreateAccountLink.Click();
        }

        public static void ClickForgotPassword()
        {
            LoginForm.ForgotPasswordLink.Click();
        }

        public static void ClickLoginButton()
        {
            LoginForm.LoginButton.Click();
        }

        public static void CompleteUserNameField(string userName)
        {
            LoginForm.UserNameField.SendKeys(userName);
        }

        public static void CompletePasswordField(string password)
        {
            LoginForm.PasswordField.SendKeys(password);
        }
    }
}
