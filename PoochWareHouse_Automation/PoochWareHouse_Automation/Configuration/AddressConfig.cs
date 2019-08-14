namespace PoochWareHouse_Automation.Configuration
{
    public class AddressConfig
    {
        public string FirstName ;
        private string Surname;
        private string Company;
        private string Address; 
        private string Apartment; 
        private string City; 
        private string Country;
        private string Postcode;
        private string PhoneNumber;
        private bool DefaultAddress;

        public AddressConfig ValidAddress()
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

    }
}
