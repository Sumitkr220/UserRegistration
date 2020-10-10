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
            bool valid= Regex.IsMatch(input, First_Name_pattern);
            try
            {
                if(valid)
                {
                    return true;
                }
                else
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT, "Invalid input");
                }
            }
            catch(NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_EXCEPTION, "Null input");
            }
        }
        public bool LastNameValidation(string input)
        {
            bool valid = Regex.IsMatch(input, Last_name_pattern);
            try
            {
                if (valid)
                {
                    return true;
                }
                else
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT, "Invalid input");
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_EXCEPTION, "Null input");
            }
        }
        public bool EmailValidation(string input)
        {
            bool valid = Regex.IsMatch(input, Email_pattern);
            try
            {
                if (valid)
                {
                    return true;
                }
                else
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT, "Invalid input");
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_EXCEPTION, "Null input");
            }
        }
        public bool MobileValidation(string input)
        {
            bool valid = Regex.IsMatch(input, Mobile_pattern);
            try
            {
                if (valid)
                {
                    return true;
                }
                else
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT, "Invalid input");
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_EXCEPTION, "Null input");
            }
        }
        public bool PasswordValidation(string input)
        { 
            bool valid = Regex.IsMatch(input, Password_pattern);
            bool validate = Regex.IsMatch(input, Password_pattern1);
            try
            {
                if (valid && validate)
                {
                    return true;
                }
                else
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT, "Invalid input");
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_EXCEPTION, "Null input");
            }
        }
    }
}
