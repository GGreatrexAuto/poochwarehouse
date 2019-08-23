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
            YourAddresses.FirstName.SendKeys(addressConfig.FirstName);
            YourAddresses.LastName.SendKeys(addressConfig.Surname);
            YourAddresses.Apartment.SendKeys(addressConfig.Apartment);
            YourAddresses.Address.SendKeys(addressConfig.Address);
            YourAddresses.Company.SendKeys(addressConfig.Company);
            YourAddresses.City.SendKeys(addressConfig.City);
            YourAddresses.Country.SendKeys(addressConfig.Country);
            YourAddresses.PostalCode.SendKeys(addressConfig.Postcode);
            YourAddresses.Phone.SendKeys(addressConfig.PhoneNumber);

            if (addressConfig.DefaultAddress == true && YourAddresses.DefaultAddressCheckbox.Selected == false)
            {
                YourAddresses.DefaultAddressCheckbox.Click();
            }
        }

        public string GetCustomerAddressOne()
        {
            return YourAddresses.AddressOneView.Text;
        }

        public string GetCustomerAddressTwo()
        {
            return YourAddresses.AddressTwoView.Text;
        }

        public void DeleteDefaultAddress()
        {
            
            YourAddresses.DeleteAddressOneButton.Click();

            IAlert deleteAddressAlert = Driver._webdriver.SwitchTo().Alert();
            deleteAddressAlert.Accept();
        }

    }
}