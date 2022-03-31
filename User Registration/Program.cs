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
                Console.WriteLine("Enter 5 for Password Rule 1:");
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
                            Console.WriteLine("Enter a Password Rule 1:");
                            string PasswordRule1 = Console.ReadLine();
                            userRegistration.ValidPasswordRule1(PasswordRule1);
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