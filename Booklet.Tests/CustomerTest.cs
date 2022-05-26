using BookletCore;

namespace Booklet.Tests
{
    public class CustomerTest 
    {
        [Fact]
        public void ConstructorTest()
        {
            var customer = new Customer(
                firstName: "Bob",
                lastName: "Jones",
                phoneNumber: "(888)888-8888",
                email: "bobjones@gmail.com",
                address: null
            );
            
            Assert.Equal("Bob", customer.FirstName);
            Assert.Equal("Jones", customer.LastName);
            Assert.Equal("(888)888-8888", customer.PhoneNumber);
            Assert.Equal("bobjones@gmail.com", customer.Email);
            Assert.Equal(null, customer.Address);
        }
    }
}