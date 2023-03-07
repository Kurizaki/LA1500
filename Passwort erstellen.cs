using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int passwordLength = 14;                                        // Länge erstellen
        string password = GenerateRandomPassword(passwordLength);       
        Console.WriteLine(password);                                    // textbox angeben wo es reinkommt anstatt console writeline
        Console.ReadKey();                                              // Die Zeile löschen sobald es im projekt ist
    }

    static string GenerateRandomPassword(int length)
    {
        const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890?!";   //Da noch mehr Zeichen nach bedarf
        StringBuilder password = new StringBuilder();
        Random random = new Random();

        while (0 < length--)
        {
            password.Append(validChars[random.Next(validChars.Length)]);
        }

        return password.ToString();
    }
}