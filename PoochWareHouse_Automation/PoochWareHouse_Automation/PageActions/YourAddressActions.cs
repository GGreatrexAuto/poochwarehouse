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
            YourAddresses.FirstName.SendKeys(addressConfig.AddressDetails().FirstName);
            YourAddresses.LastName.SendKeys(addressConfig.AddressDetails().Surname);
            YourAddresses.Apartment.SendKeys(addressConfig.AddressDetails().Apartment);
            YourAddresses.Address.SendKeys(addressConfig.AddressDetails().Address);
            YourAddresses.Company.SendKeys(addressConfig.AddressDetails().Company);
            YourAddresses.City.SendKeys(addressConfig.AddressDetails().City);
            YourAddresses.Country.SendKeys(addressConfig.AddressDetails().Country);
            YourAddresses.PostalCode.SendKeys(addressConfig.AddressDetails().Postcode);
            YourAddresses.Phone.SendKeys(addressConfig.AddressDetails().PhoneNumber);

            if (addressConfig.DefaultAddress == true && YourAddresses.DefaultAddressCheckbox.Selected == false)
            {
                YourAddresses.DefaultAddressCheckbox.Click();
            }
        }

        public string GetDefaultCustomerAddress()
        {
            return YourAddresses.DefaultAddressView.Text;
        }

        public void DeleteDefaultAddress()
        {
            
            YourAddresses.DeleteButton.Click();

            IAlert deleteAddressAlert = Driver._webdriver.SwitchTo().Alert();
            deleteAddressAlert.Accept();
        }

    }
}