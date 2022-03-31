﻿using System;
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
    }
}

