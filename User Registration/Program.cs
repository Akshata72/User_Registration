using System.Text.RegularExpressions;
namespace UserReg
{
    class UserRegex
    {
        static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Enter a First name:");
            string FirstName = Console.ReadLine();
            userRegistration.ValidFirstName(FirstName);
        }
    }
}