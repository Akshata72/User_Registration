using NUnit.Framework;

namespace UserRegex
{
    public class Tests
    {
        UserRegistration userRegistration;

        [SetUp]
        public void Setup()
        {
            userRegistration = new UserRegistration();
        }
        [Test]
        public void Given_FirstName_When_Valid_shouldReturn_Valid()
        {
            string result = userRegistration.ValidFirstName("Akshata");
            Assert.AreEqual("First Name is valid", result);
        }
        [Test]
        public void Given_LastName_WhenValid_shouldReturn_Valid()
        {
            string result = userRegistration.ValidLastName("Sabale");
            Assert.AreEqual("Last Name is valid", result);
        }
        [Test]
        public void Given_EmailID_When_Valid_ShouldReturn_Valid()
        {
            string result = userRegistration.ValidEmailID("abc@bl.co");
            Assert.AreEqual("EmailID is valid", result);
        }
        [Test]
        public void Given_MobileNumber_When_Valid_ShouldReturn_Valid()
        {
            string result = userRegistration.ValidPhoneNumber("91 4564485454");
            Assert.AreEqual("Phone Number is valid", result);

        }
        [Test]
        public void Given_Password_When_valid_ShouldReturn_Valid()
        {
            string result = userRegistration.ValidPasswordRule4("@Akshata8");
            Assert.AreEqual("Password At least 1 Special Character is valid", result);
        }

       
    }
}
