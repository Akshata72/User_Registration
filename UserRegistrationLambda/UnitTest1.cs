using NUnit.Framework;

namespace UserRegistration
{
    public class Tests
    {
        UserRegistrationLambda userRegistration;

        [SetUp]
        public void Setup()
        {
            userRegistration = new UserRegistrationLambda();
        }

        [TestCase("Akshata")]
        [TestCase("Ak")]
        public void Given_firstName_Expecting_ThrowCustomException(string PatternFirstName)
        {
            try
            {
                string actual = userRegistration.FirstNameLambda(PatternFirstName);
            }
            catch(UserRegistrationCustomException exception)
            {
                Assert.AreEqual("firstname is not valid", exception.Message);
            }
            
        }

        [TestCase("Sabale")]
        [TestCase("Sa")]
        public void Given_lastName_Expecting_ThrowCustomException(string PatternLastName)
        {
            try
            {
                string actual = userRegistration.FirstNameLambda(PatternLastName);
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
                string actual = userRegistration.EmailIDLambda(PatternEmailID);
            }
            catch(UserRegistrationCustomException exception)
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
                string actual = userRegistration.MobileNumberLambda(PatternMobileNumber);
            }
            catch(UserRegistrationCustomException exception)
            {
                Assert.AreEqual("mobile number is not valid", exception.Message);
            }
        }

        [TestCase("@Akshata70")]
        public void Given_Password_Excepting_ThrowCustomException(string PatternPassword)
        {
            try
            {
                string actual = userRegistration.PasswordLambda(PatternPassword);
            }
            catch(UserRegistrationCustomException exception)
            {
                Assert.AreEqual("password is not valid", exception.Message);
            }
        }
    }
}