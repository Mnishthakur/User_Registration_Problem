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
        return password.Length >= 8;
    }
}
