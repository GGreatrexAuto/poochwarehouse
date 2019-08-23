namespace PoochWareHouse_Automation.Configuration
{
    public class AddressConfig
    {
        public string FirstName ;
        public string Surname;
        public string Company;
        public string Address; 
        public string Apartment; 
        public string City; 
        public string Country;
        public string Postcode;
        public string PhoneNumber;
        public bool DefaultAddress;

        public AddressConfig DefaultAddressDetails()
        {
            return new AddressConfig
            {
                FirstName = "Gareth",
                Surname = "Test",
                Company = "Tester Ltd",
                Address = "AddressTestone",
                Apartment = "999666",
                City = "Doja",
                Country = "Albania",
                Postcode = "BS11 1XX",
                PhoneNumber = "07999111999",
                DefaultAddress = true

            };
        }

        public AddressConfig FurtherAddressDetails()
        {
            return new AddressConfig
            {
                FirstName = "Rhys",
                Surname = "Testers",
                Company = "PoochWareHouse",
                Address = "AddressTesttwo",
                Apartment = "11A",
                City = "Cardiff",
                Country = "United Kingdom",
                Postcode = "CF5 2ZZ",
                PhoneNumber = "07888222888",
                DefaultAddress = false
            };


        }
    }
