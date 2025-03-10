using System.Security.Cryptography.X509Certificates;

namespace BasicOppgave1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the temperature currently?");
        int temp = 0;

        string? userInput = Console.ReadLine();

        if(int.TryParse(userInput, out temp) && temp <= 11)
        {
            Console.WriteLine("It is cold outside");

        }
        else if (temp >= 23)
        {
            Console.WriteLine("It is hot outside");
        }
        else
        {
            Console.WriteLine("It is a nice temperature outside");
        }
    }
}
