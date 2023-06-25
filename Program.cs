using System.Text.RegularExpressions;
namespace User_Registration_Problem;

class Program
{
    static void Main()
    {
        Console.Write("Enter a mobile number: ");
        string mobileNumber = Console.ReadLine();

        if (IsValidMobileNumber(mobileNumber))
        {
            Console.WriteLine("Valid mobile number!");
        }
        else
        {
            Console.WriteLine("Invalid mobile number!");
        }
    }

    static bool IsValidMobileNumber(string mobileNumber)
    {
        string pattern = @"^\d{2}\s\d{10}$";
        return Regex.IsMatch(mobileNumber, pattern);
    }
}
