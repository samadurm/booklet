namespace BookletCore
{
    public class Address 
    {
        public string StreetName { get; set; }
        public string? AptNumber { get; set; }
        public string City{ get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string ZipCode;

        public Address(string streetName, string? aptNumber, string city, string state, string zipCode)
        {
            if (aptNumber != null)
            {
                AptNumber = aptNumber;
            }
            StreetName = streetName; 
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
}