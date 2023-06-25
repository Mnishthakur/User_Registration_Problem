using System.Text.RegularExpressions;
namespace User_Registration_Problem;

class Program
{
    static void Main()
    {
        Console.Write("Enter a first name: ");
        string firstName = Console.ReadLine();

        if (IsValidFirstName(firstName))
        {
            Console.WriteLine("First Name is Valid");
        }
        else
        {
            Console.WriteLine("Invalid Name");
        }
    }

    static bool IsValidFirstName(string firstName)
    {
        string pattern = @"^[A-Z][a-zA-Z]{2,}$";
        return Regex.IsMatch(firstName, pattern);
    }
}
