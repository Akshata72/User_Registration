using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace UserReg
{
    public class UserRegistration
    {
        public Regex FirstNameRegex = new Regex(@"^[A-Za-z]{2,}$");
        public void ValidFirstName(string FirstName)
        {
            Console.WriteLine("First Name:" + FirstName);
            if (FirstNameRegex.IsMatch(FirstName))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("First name is invalid");
            }
        }
    }
}
