using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registraton");
            Console.WriteLine("Enter the User First Name");
            string firstName = Console.ReadLine();
            string pattern = "^[A-Z]+[a-z A-Z]{2,}";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(firstName);
            if (match.Success)
            {
                Console.WriteLine("User First Name matches with Pattern Successfully");
            }
            else
            {
                Console.WriteLine("User First Name not matches with Pattern");
            }
        }
    }
}
