using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoochWareHouse_Automation.Configuration;
using PoochWareHouse_Automation.Pages;

namespace PoochWareHouse_Automation.PageActions
{
    public class YourAddressActions
    {
        private AddressConfig _addressConfig = new AddressConfig();

        public static void PopulateCustomerAddress(AddressConfig addressconfig)
        {
            YourAddresses.FirstName.SendKeys(addressconfig.ValidAddress().FirstName);
            YourAddresses.LastName.SendKeys();
            YourAddresses.Apartment.SendKeys();
            YourAddresses.Address.SendKeys();
            YourAddresses.Company.SendKeys();
            YourAddresses.City.SendKeys();
            YourAddresses.Country.SendKeys();
            YourAddresses.PostalCode.SendKeys();
            YourAddresses.Phone.SendKeys();
            YourAddresses.DefaultAddressCheckbox.Click();
        }

    }
}