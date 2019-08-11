using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoochWareHouse_Automation.Pages;

namespace PoochWareHouse_Automation.Navigation
{
    public static class MyAccountNavigation
    {
        public static void ClickLogOutLink()
        {
            MyAccount.LogOutLink.Click();
        }

        public static void ClickViewAddressesButton()
        {
            MyAccount.ViewAddressButton.Click();
        }
    }
}
