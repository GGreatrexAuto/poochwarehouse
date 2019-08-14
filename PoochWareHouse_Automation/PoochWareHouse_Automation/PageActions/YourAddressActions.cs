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
            YourAddresses.FirstName.SendKeys(addressconfig.AddressDetails().FirstName);
            YourAddresses.LastName.SendKeys(addressconfig.AddressDetails().Surname);
            YourAddresses.Apartment.SendKeys(addressconfig.AddressDetails().Apartment);
            YourAddresses.Address.SendKeys(addressconfig.AddressDetails().Address);
            YourAddresses.Company.SendKeys(addressconfig.AddressDetails().Company);
            YourAddresses.City.SendKeys(addressconfig.AddressDetails().City);
            YourAddresses.Country.SendKeys(addressconfig.AddressDetails().Country);
            YourAddresses.PostalCode.SendKeys(addressconfig.AddressDetails().Postcode);
            YourAddresses.Phone.SendKeys(addressconfig.AddressDetails().PhoneNumber);

            if (addressconfig.DefaultAddress == true && YourAddresses.DefaultAddressCheckbox.Selected == false)
            {
                YourAddresses.DefaultAddressCheckbox.Click();
            }
        }
    }
}