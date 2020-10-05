using System;
using System.Text.RegularExpressions;

namespace UserRegistrationUC
{
    class Program
    {
        public static void FirstNameValidation(string input)
        {
            string pattern = "^[A-Z]+[a-z A-Z]{2,}";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            if (match.Success)
            {
                Console.WriteLine("User First Name matches with Pattern Successfully");
            }
            else
            {
                Console.WriteLine("User First Name not matches with Pattern");
            }
        }
        public static void LastNameValidation(string input)
        {
            string pattern = "^[A-Z]+[a-z A-Z]{2,}";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            if (match.Success)
            {
                Console.WriteLine("User Last Name matches with Pattern Successfully");
            }
            else
            {
                Console.WriteLine("User Last Name not matches with Pattern");
            }
        }
        public static void EmailValidation(string input)
        {
            string pattern = "^[a-zA-Z]+[.][a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}[.][a-zA-z]{2,3}";
            bool validate = Regex.IsMatch(input, pattern);
            if (validate)
            {
                Console.WriteLine("User Email matches with Pattern Successfully");
            }
            else
            {
                Console.WriteLine("User Email not matches with Pattern");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registraton");
            Console.WriteLine("Enter the User First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the User Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the User Email");
            string eMail = Console.ReadLine();
            FirstNameValidation(firstName);
            LastNameValidation(lastName);
            EmailValidation(eMail);
        }
    }
}
