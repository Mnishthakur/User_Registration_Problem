using System.Text.RegularExpressions;
namespace User_Registration_Problem;

class Program
{
    static void Main()
    {
        string[] emailSamples = {
            "abc.xyz@bl.co.in",
            "test@example.com",
            "john.doe@gmail.com",
            "invalid_email",
            "user@123.com"
        };

        foreach (string email in emailSamples)
        {
            if (IsValidEmail(email))
            {
                Console.WriteLine($"{email} - Valid email address!");
            }
            else
            {
                Console.WriteLine($"{email} - Invalid email address!");
            }
        }
    }

    static bool IsValidEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-]?[a-zA-Z0-9]+)*\.[a-zA-Z]{2,}$";
        return Regex.IsMatch(email, pattern);
    }
}
