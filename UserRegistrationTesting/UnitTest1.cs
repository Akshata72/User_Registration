using NUnit.Framework;

namespace UserRegex
{
    public class Tests
    {
        UserRegistration userRegistration;
        InvalidUserRegistration invalidUserRegistration;

        [SetUp]
        public void Setup()
        {
            userRegistration = new UserRegistration();
            invalidUserRegistration = new InvalidUserRegistration();
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

        [TestCase("abc-100@yahoo.com")]
        [TestCase("xyz-880@gmail.com")]
        public void Given_Email_When_valid_ShouldReturn_Valid(string PatternEmailID)
        { 
            try
            {
                string actual = userRegistration.ValidCheckEmailID(PatternEmailID);
            }
            catch (UserRegistrationCustomException exception)
            {
                Assert.AreEqual("EmailID is valid", exception.Message);
            }
        }
        [TestCase("Akshata")]
        public void Given_firstName_Expecting_ThrowCustomException(string PatternFirstName)
        {
            try
            {
                string actual = invalidUserRegistration.InvalidFirstName(PatternFirstName);
            }
            catch (UserRegistrationCustomException exception)
            {
                Assert.AreEqual("firstname is not valid", exception.Message);
            }
        }
        [TestCase("Sabale")]
        public void Given_lastName_Expecting_ThrowCustomException(string PatternLastName)
        {
            try
            {
                string actual = invalidUserRegistration.InvalidLastName(PatternLastName);
            }
            catch (UserRegistrationCustomException exception)
            {
                Assert.AreEqual("lastname is not valid", exception.Message);
            }
        }

        [TestCase("Sable880@gmail.com")]
        [TestCase("sable")]
        public void Given_EmailID_Expecting_ThrowCustomException(string PatternEmailID)
        {
            try
            {
                string actual = invalidUserRegistration.InvalidEmailID(PatternEmailID);
            }
            catch (UserRegistrationCustomException exception)
            {
                Assert.AreEqual("emailID is not valid", exception.Message);
            }
        }

        [TestCase("91 7546121452")]
        [TestCase("45 5202235865")]
        public void Given_MobileNumber_Expecting_ThrowCustomException(string PatternMobileNumber)
        {
            try
            {
                string actual = invalidUserRegistration.InvalidMobileNumber(PatternMobileNumber);
            }
            catch (UserRegistrationCustomException exception)
            {
                Assert.AreEqual("mobile number is not valid", exception.Message);
            }
        }

        [TestCase("@Akshata70")]
        public void Given_Password_Excepting_ThrowCustomException(string PatternPassword)
        {
            try
            {
                string actual = invalidUserRegistration.InvalidPassword(PatternPassword);
            }
            catch (UserRegistrationCustomException exception)
            {
                Assert.AreEqual("password is not valid", exception.Message);
            }
        }
    }
}
