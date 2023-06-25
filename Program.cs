using System.Text.RegularExpressions;
namespace User_Registration_Problem;

class Program
{
    static void Main()
    {
        Console.Write("Enter a first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        if (IsValidFirstName(firstName) && IsValidLastName(lastName))
        {
            Console.WriteLine("Name is Valid");
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

    static bool IsValidLastName(string lasName)
    {
        string pattern = @"^[A_Z}{1}[a-zA-Z]{2,}";
        return Regex.IsMatch(lasName, pattern);
    }
}
