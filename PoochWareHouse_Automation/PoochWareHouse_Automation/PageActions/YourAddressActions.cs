using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PoochWareHouse_Automation.Configuration;
using PoochWareHouse_Automation.Pages;

namespace PoochWareHouse_Automation.PageActions
{
    public class YourAddressActions
    {
        private AddressConfig _addressConfig = new AddressConfig();

        public void PopulateCustomerAddress(AddressConfig addressConfig)
        {
            YourAddresses.FirstName.SendKeys(addressConfig.DefaultAddressDetails().FirstName);
            YourAddresses.LastName.SendKeys(addressConfig.DefaultAddressDetails().Surname);
            YourAddresses.Apartment.SendKeys(addressConfig.DefaultAddressDetails().Apartment);
            YourAddresses.Address.SendKeys(addressConfig.DefaultAddressDetails().Address);
            YourAddresses.Company.SendKeys(addressConfig.DefaultAddressDetails().Company);
            YourAddresses.City.SendKeys(addressConfig.DefaultAddressDetails().City);
            YourAddresses.Country.SendKeys(addressConfig.DefaultAddressDetails().Country);
            YourAddresses.PostalCode.SendKeys(addressConfig.DefaultAddressDetails().Postcode);
            YourAddresses.Phone.SendKeys(addressConfig.DefaultAddressDetails().PhoneNumber);

            if (addressConfig.DefaultAddress == true && YourAddresses.DefaultAddressCheckbox.Selected == false)
            {
                YourAddresses.DefaultAddressCheckbox.Click();
            }
        }

        public string GetDefaultCustomerAddress()
        {
            return YourAddresses.AddressOneView.Text;
        }

        public void DeleteDefaultAddress()
        {
            
            YourAddresses.DeleteAddressOneButton.Click();

            IAlert deleteAddressAlert = Driver._webdriver.SwitchTo().Alert();
            deleteAddressAlert.Accept();
        }

    }
}