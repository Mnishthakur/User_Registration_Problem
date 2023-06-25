using System.Text.RegularExpressions;
namespace User_Registration_Problem;

class Program
{
    static void Main()
    {
        Console.Write("Enter a password: ");
        string password = Console.ReadLine();

        if (IsValidPassword(password))
        {
            Console.WriteLine("Valid password!");
        }
        else
        {
            Console.WriteLine("Invalid password!");
        }
    }

    static bool IsValidPassword(string password)
    {
        // Rule 1: Minimum 8 characters
        if (password.Length < 8)
        {
            return false;
        }

        // Rule 2: At least 1 uppercase letter
        string uppercasePattern = @"[A-Z]";
        if (!Regex.IsMatch(password, uppercasePattern))
        {
            return false;
        }

        // Rule 3: At least 1 numeric number
        string numericPattern = @"\d";
        if (!Regex.IsMatch(password, numericPattern))
        {
            return false;
        }

        // Rule 4: Exactly 1 special character
        string specialCharPattern = @"^[a-zA-Z0-9]*[^a-zA-Z0-9]{1}[a-zA-Z0-9]*$";
        if (!Regex.IsMatch(password, specialCharPattern))
        {
            return false;
        }

        // All rules passed
        return true;
    }
}
