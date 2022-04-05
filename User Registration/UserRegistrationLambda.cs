using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserRegistrationLambda
    {
        string FirstNamePattern = "^[A-Z{1}[a-z]{2,}$";
        public bool FirstName(string PatternFirstName) => Regex.IsMatch(PatternFirstName, FirstNamePattern);
        public string FirstNameLambda(string PatternFirstName)
        {
            bool result = FirstName(PatternFirstName);
            try
            {
                if (result == false)
                {
                    if (PatternFirstName.Equals(string.Empty))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_ENTERED_EMPTY, "firstname should not be empty");
                    }
                    if (PatternFirstName.Length < 3)
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_LESSTHAN_MINIMUM_LENGTH, " firstname should contains minimum length");
                    }
                    if (PatternFirstName.Any(char.IsDigit))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_ENTERED_NUMBER, "firstname should not contain number");
                    }
                    if (!char.IsUpper(PatternFirstName[0]))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_ENTERED_LOWERCASE, "firstname first latter should not small latter");
                    }
                    if (PatternFirstName.Any(char.IsLetterOrDigit))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_ENTERED_SPECIAL_CHARACTER, "firstname should not contain special character");
                    }
                    return "SAD";
                }
                else return "HAPPY";
            }
            catch (UserRegistrationCustomException exception)
            {
                throw exception;
            }
            return "firstname is not valid";
        }

        string LastNamePattern = "^[A-Z{1}[a-z]{2,}$";
        public bool LastName(string PatternLastName) => Regex.IsMatch(PatternLastName, LastNamePattern);
        public string LastNameLambda(string PatternLastName)
        {
            bool result = LastName(PatternLastName);
            try
            {
                if (result == false)
                {
                    if (PatternLastName.Equals(string.Empty))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_ENTERED_EMPTY, "lastname should not be empty");
                    }
                    if (PatternLastName.Length < 3)
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_LESSTHAN_MINIMUM_LENGTH, "lastname should contains minimum length");
                    }
                    if (PatternLastName.Any(char.IsDigit))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_ENTERED_NUMBER, "lastname should not contain number");
                    }
                    if (!char.IsUpper(PatternLastName[0]))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_ENTERED_LOWERCASE, "lastname first latter should not small latter");
                    }
                    if (PatternLastName.Any(char.IsLetterOrDigit))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_ENTERED_SPECIAL_CHARACTER, "lastname should not contain special character");
                    }
                    return "SAD";

                }
                else return "HAPPY";
            }
            catch (UserRegistrationCustomException exception)
            {
                throw exception;
            }
            return "lastname is not valid";
        }

        string EmailIDPattern = "^[A-Za-z]+([.+-][A-Za-z0-9]+)*@[A-Za-z0-9]+.[A-Za-z]([.][A-Za-z]{2,})?$";
        public bool EmailID(string PatternEmailID) => Regex.IsMatch(PatternEmailID, EmailIDPattern);
        public string EmailIDLambda(string PatternEmailID)
        {
            bool result = EmailID(PatternEmailID);
            try
            {
                if (result == false)
                {
                    if (PatternEmailID.Equals(string.Empty))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_ENTERED_EMPTY, "emailId should not be empty");
                    }
                    if (!char.IsLetterOrDigit(PatternEmailID[0]))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_NOT_ENTERED_LETTER_OR_DIGIT, "emailID should not be null");
                    }
                    if (PatternEmailID.Length < 3)
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_LESSTHAN_MINIMUM_LENGTH, "emailID should contains minimum length");
                    }
                    if (!char.IsUpper(PatternEmailID[0]))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_ENTERED_ATLEAST__ONE_UPPERCASE_LATTER, "emailID is not valid");
                    }
                    if (!char.IsLower(PatternEmailID[0]))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_ENTERED_ATLEAST__ONE_LOWERCASE_LATTER, "emailID is not valid");
                    }
                    return "SAD";
                }
                else return "HAPPY";
            }
            catch (UserRegistrationCustomException exception)
            {
                throw exception;
            }
            return "emailID is not valid";
        }

        string MobileNumberPattern = "^[0-9]{2} [0-9]{10}$";
        public bool MobileNumber(string PaternMobileNumber) => Regex.IsMatch(PaternMobileNumber, MobileNumberPattern);
        public string MobileNumberLambda(string PatternMoileNumber)
        {
            bool result = MobileNumber(PatternMoileNumber);
            try
            {
                if (result == false)
                {
                    if (PatternMoileNumber.Equals(string.Empty))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_ENTERED_EMPTY, "mobile number should not be empty");
                    }
                    if (!char.IsLetter(PatternMoileNumber[0]))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_ENTERED_LETTERS, "mobile number should not contain any letter");
                    }
                    if (PatternMoileNumber.Any(char.IsLetterOrDigit))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_ENTERED_SPECIAL_CHARACTER, "mobile number should not contain special character");
                    }
                    if (PatternMoileNumber.Length < 12)
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_LESSTHAN_LENGTH, "mobile number should contains length");
                    }
                }
            }
            catch (UserRegistrationCustomException exception)
            {
                throw exception;
            }
            return "mobile number is not valid";
        }

        string PasswordPattern = "^[$]{1,}(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{5,}$";
        public bool Password(string PaternPassword) => Regex.IsMatch(PaternPassword, PasswordPattern);
        public string PasswordLambda(string PatternPassword)
        {
            bool result = Password(PatternPassword);
            try
            {
                if(result == false)
                {
                    if (PatternPassword.Equals(string.Empty))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_ENTERED_EMPTY, "password should not be empty");
                    }
                    if (!char.IsDigit(PatternPassword[0]))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_DOES_NOT_ENTERED_ANYDIGIT, "password is not valid");
                    }
                    if (!char.IsLetter(PatternPassword[0]))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_DOES_NOT_ENTERED_UPPERCASE_LATTER, "password is not valid");
                    }
                    if (!char.IsSymbol(PatternPassword[0]))
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.USER_DOSE_NOT_ENTERED_ANYSYMBOL, "password is not valid");
                    }
                }
            }
            catch(UserRegistrationCustomException exception)
            {
                throw exception;
            }
            return "password is not valid";
        }
    }
}
