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

        public AddressConfig GetAddress()
        {
            return new AddressConfig
            {
                Company = YourAddresses.CompanyDefaultView.Text,
                FirstName = YourAddresses.FullNameDefaultView.Text,
                Surname = YourAddresses.FullNameDefaultView.Text,
                Address = YourAddresses.AddressDefaultView.Text,
                Apartment = YourAddresses.ApartmentDefaultView.Text,
                City = YourAddresses.PostcodeCityDefaultView.Text,
                Country = YourAddresses.CountryDefaultView.Text,
                Postcode = YourAddresses.PostcodeCityDefaultView.Text


            };
        }
    }
}