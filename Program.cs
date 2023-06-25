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
        string pattern = @"[A-Z]";
        if (!Regex.IsMatch(password, pattern))
        {
            return false;
        }

        // All rules passed
        return true;
    }
}
