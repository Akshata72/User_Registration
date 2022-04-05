using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace UserRegex
{
    public class UserRegistration
    {
        public Regex FirstNameRegex = new Regex(@"^[A-Z]{1,}[A-Za-z]{2,}$");
        public Regex LastNameRegex = new Regex(@"^[A-Z]{1,}[A-Za-z]{2,}$");
        public Regex EmailIDRegex = new Regex(@"^[a-z]{3,}([.]{1}[a-z]{3,})?@bl.co([.]{1}[a-z]{2})?$");
        public Regex PhoneNumberRegex = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public Regex PasswordRule1Regex = new Regex(@"^[A-Za-z]{8,}$");
        public Regex PasswordRule2Regex = new Regex(@"^(?=.*[A-Z]{1,})[A-Za-z]{7,}$");
        public Regex PasswordRule3Regex = new Regex(@"^(?=.*[A-Z]{1,})(?=.*[0-9]{1,})[A-Za-z0-9]{6,}$");
        public Regex PasswordRule4Regex = new Regex(@"^[\w\W]{1,}(?=.*[A-Z]{1,})(?=.*[0-9]{1,})[A-Za-z0-9]{5,}$");
        public Regex CheckEmailIDRegex = new Regex(@"^[a-z]{3,}(([.|+]{1})?([-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.[a-z]{3}(.[a-z]{2,4})?$");
        public string ValidFirstName(string FirstName)
        {
            Console.WriteLine("\nFirst Name:" + FirstName);
            if (FirstNameRegex.IsMatch(FirstName))
                return "First Name is valid";
            else
            return "First Name is invalid";
        }
        public string ValidLastName(string LastName)
        {
            Console.WriteLine("\nLast Name:" + LastName);
            if (LastNameRegex.IsMatch(LastName))
                return "Last Name is valid";
            else
                return "Last Name is invalid";
        }
        public string ValidEmailID(string EmailID)
        {
            Console.WriteLine("\nEmailID:" + EmailID);
            if (EmailIDRegex.IsMatch(EmailID))
                return "EmailID is valid";
            else
                return "EmailID is invalid";
        }
        public string ValidPhoneNumber(string PhoneNumber)
        {
            Console.WriteLine("\nPhone Number:" + PhoneNumber);
            if (PhoneNumberRegex.IsMatch(PhoneNumber))
                return "Phone Number is valid";
            else
                return "Phone Number is invalid";
        }
        public string ValidPasswordRule1(string PasswordRule1)
        {
            Console.WriteLine("\nPassword At least Minimum 8 Char:" + PasswordRule1);
            if (PasswordRule1Regex.IsMatch(PasswordRule1))
                return "Password At least Minimum 8 Char is valid";
            else
                return "Password At least Minimum 8 Char is invalid";
        }
        public string ValidPasswordRule2(string PasswordRule2)
        {
            Console.WriteLine("\nPassword At least 1 Upper Case:" + PasswordRule2);
            if (PasswordRule2Regex.IsMatch(PasswordRule2))
                return "Password At least 1 Upper Case is valid";
            else
                return "Password At least 1 Upper Case is invalid";
        }
        public string ValidPasswordRule3(string PasswordRule3)
        {
            Console.WriteLine("\nPassword At least 1 Numeric number:" + PasswordRule3);
            if (PasswordRule3Regex.IsMatch(PasswordRule3))
                return "Password At least 1 Numeric number is valid";
            else
                return "Password At least 1 Numeric number is invalid";
        }
        public string ValidPasswordRule4(string PasswordRule4)
        {
            Console.WriteLine("\nPassword At least 1 Special Character:" + PasswordRule4);
            if (PasswordRule4Regex.IsMatch(PasswordRule4))
                return "Password At least 1 Special Character is valid";
            else
                return "Password At least 1 Special Character is invalid";
        }
        public string ValidCheckEmailID(string CheckEmailID)
        {
            Console.WriteLine("\nEmailID:" + CheckEmailID);
            if (CheckEmailIDRegex.IsMatch(CheckEmailID))
                return "EmailID is valid";
            else
                return "EmailID is invalid";
        }
    }
}

