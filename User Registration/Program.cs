using System.Text.RegularExpressions;
namespace UserRegex
{
    class UserRegex
    {
        static void Main(string[] args)
        {
            int Option = 0;
            UserRegistration userRegistration = new UserRegistration();
            do
            {
                Console.WriteLine("Enter 1 for First Name:");
                Console.WriteLine("Enter 2 for Last Name:");
                Console.WriteLine("Enter 3 for Email ID:");
                Console.WriteLine("Enter 4 for Phone number:");
                Console.WriteLine("Enter 5 for Password At least Minimum 8 Char:");
                Console.WriteLine("Enter 6 for Password At least 1 Upper Case:");
                Console.WriteLine("Enter 7 for Password At least 1 Numeric number:");
                Console.WriteLine("Enter 0 to Exit:");
                try
                {
                    Option = int.Parse(Console.ReadLine());
                    switch (Option)
                    {
                        case 1:
                            Console.WriteLine("Enter a First name:");
                            string FirstName = Console.ReadLine();
                            userRegistration.ValidFirstName(FirstName);
                            break;
                        case 2:
                            Console.WriteLine("Enter a Last name:");
                            string LastName = Console.ReadLine();
                            userRegistration.ValidLastName(LastName);
                            break;
                        case 3:
                            Console.WriteLine("Enter a Email ID:");
                            string EmailID = Console.ReadLine();
                            userRegistration.ValidEmailID(EmailID);
                            break;
                        case 4:
                            Console.WriteLine("Enter a Phone number:");
                            string PhoneNumber = Console.ReadLine();
                            userRegistration.ValidPhoneNumber(PhoneNumber);
                            break;
                        case 5:
                            Console.WriteLine("Enter a Password At least Minimum 8 Char:");
                            string PasswordRule1 = Console.ReadLine();
                            userRegistration.ValidPasswordRule1(PasswordRule1);
                            break;
                        case 6:
                            Console.WriteLine("Enter a Password At least 1 Upper Case:");
                            string PasswordRule2 = Console.ReadLine();
                            userRegistration.ValidPasswordRule2(PasswordRule2);
                            break;
                        case 7:
                            Console.WriteLine("Enter a Password At least 1 Numeric number:");
                            string PasswordRule3 = Console.ReadLine();
                            userRegistration.ValidPasswordRule3(PasswordRule3);
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Choose option");
                }
            }
            while (Option != 0);
        }
    }
}