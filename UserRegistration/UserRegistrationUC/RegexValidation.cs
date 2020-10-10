using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUC
{
    public class RegexValidation
    {
        public static string First_Name_pattern = "^[A-Z]+[a-z A-Z]{2,}";
        public static string Last_name_pattern = "^[A-Z]+[a-z A-Z]{2,}";
        public static string Email_pattern = "^[a-zA-Z]+[.][a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}[.][a-zA-z]{2,3}";
        public static string Mobile_pattern = "^[0-9]{2,3}[ ][0-9]{10}";
        public static string Password_pattern = "(?=.*[0-9])(?=.*[!@#$%^&*?])(?=.*[A-Z]).{8,}";
        public static string Password_pattern1 = "^(?=.*[0-9A-Za-z])[0-9A-Za-z]*[$&+,:;=?@#|'<>.-^*()%!][0-9A-Za-z]*$";
        public bool FirstNameValidation(string input)
        {
            return Regex.IsMatch(input, First_Name_pattern);
        }
        public bool LastNameValidation(string input)
        {
            return Regex.IsMatch(input, Last_name_pattern);
        }
        public bool EmailValidation(string input)
        {
            return Regex.IsMatch(input, Email_pattern);
        }
        public bool MobileValidation(string input)
        {
            return Regex.IsMatch(input, Mobile_pattern);
        }
        public bool PasswordValidation(string input)
        { 
            bool valid = Regex.IsMatch(input, Password_pattern);
            bool validate = Regex.IsMatch(input, Password_pattern1);
            if (valid && validate)
            {
                return true;
            }
            else
                return false;
        }
    }
}
