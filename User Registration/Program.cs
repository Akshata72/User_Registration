﻿using System.Text.RegularExpressions;
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