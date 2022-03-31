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
        public Regex FirstNameRegex = new Regex(@"^[A-Za-z]{2,}$");
        public Regex LastNameRegex = new Regex(@"^[A-Za-z]{2,}$");
        public Regex EmailIDRegex = new Regex(@"^[A-Za-z]+([.+-][A-Za-z0-9]+)*@[A-Za-z0-9]+.[A-Za-z]([.][A-Za-z]{2,})?$");
        public Regex PhoneNumberRegex = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public Regex PasswordRule1Regex = new Regex(@"^[A-Za-z]{8,}$");
        public Regex PasswordRule2Regex = new Regex(@"^(?=.*[A-Z])[A-Za-z]{7,}$");
        public Regex PasswordRule3Regex = new Regex(@"^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{6,}$");
        public Regex PasswordRule4Regex = new Regex(@"^[\w\W]{1,}(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{5,}$");
        public Regex CheckEmailIDRegex = new Regex(@"^[a-z]{3,}(([.|+]{1})?([-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.[a-z]{3}(.[a-z]{2,4})?$");
        public void ValidFirstName(string FirstName)
        {
            Console.WriteLine("\nFirst Name:" + FirstName);
            if (FirstNameRegex.IsMatch(FirstName))
            {
                Console.WriteLine("First Name is valid\n");
            }
            else
            {
                Console.WriteLine("First Name is invalid\n");
            }
        }
        public void ValidLastName(string LastName)
        {
            Console.WriteLine("\nLast Name:" + LastName);
            if (LastNameRegex.IsMatch(LastName))
            {
                Console.WriteLine("Last Name is valid\n");
            }
            else
            {
                Console.WriteLine("Last Name is invalid\n");
            }
        }
        public void ValidEmailID(string EmailID)
        {
            Console.WriteLine("\nEmailID:" + EmailID);
            if (EmailIDRegex.IsMatch(EmailID))
            {
                Console.WriteLine("EmailID is valid\n");
            }
            else
            {
                Console.WriteLine("EmailID is invalid\n");
            }
        }
        public void ValidPhoneNumber(string PhoneNumber)
        {
            Console.WriteLine("\nPhone Number:" + PhoneNumber);
            if (PhoneNumberRegex.IsMatch(PhoneNumber))
            {
                Console.WriteLine("Phone Number is valid\n");
            }
            else
            {
                Console.WriteLine("Phone Number is invalid\n");
            }
        }
        public void ValidPasswordRule1(string PasswordRule1)
        {
            Console.WriteLine("\nPassword At least Minimum 8 Char:" + PasswordRule1);
            if (PasswordRule1Regex.IsMatch(PasswordRule1))
            {
                Console.WriteLine("Password At least Minimum 8 Char is valid\n");
            }
            else
            {
                Console.WriteLine("Password At least Minimum 8 Char is invalid\n");
            }
        }
        public void ValidPasswordRule2(string PasswordRule2)
        {
            Console.WriteLine("\nPassword At least 1 Upper Case:" + PasswordRule2);
            if (PasswordRule2Regex.IsMatch(PasswordRule2))
            {
                Console.WriteLine("Password At least 1 Upper Case is valid\n");
            }
            else
            {
                Console.WriteLine("Password At least 1 Upper Case is invalid\n");
            }
        }
        public void ValidPasswordRule3(string PasswordRule3)
        {
            Console.WriteLine("\nPassword At least 1 Numeric number:" + PasswordRule3);
            if (PasswordRule3Regex.IsMatch(PasswordRule3))
            {
                Console.WriteLine("Password At least 1 Numeric number is valid\n");
            }
            else
            {
                Console.WriteLine("Password At least 1 Numeric number is invalid\n");
            }
        }
        public void ValidPasswordRule4(string PasswordRule4)
        {
            Console.WriteLine("\nPassword At least 1 Special Character:" + PasswordRule4);
            if (PasswordRule4Regex.IsMatch(PasswordRule4))
            {
                Console.WriteLine("Password At least 1 Special Character is valid\n");
            }
            else
            {
                Console.WriteLine("Password At least 1 Special Character is invalid\n");
            }
        }
        public void ValidCheckEmailID(string CheckEmailID)
        {
            Console.WriteLine("\nEmailID:" + CheckEmailID);
            if (CheckEmailIDRegex.IsMatch(CheckEmailID))
            {
                Console.WriteLine("EmailID is valid\n");
            }
            else
            {
                Console.WriteLine("EmailID is invalid\n");
            }
        }
    }
}

