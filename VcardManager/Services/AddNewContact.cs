using System.Text.RegularExpressions;
using System.IO;

namespace VcardManager
{
    public class AddNewContact
    {
        public static void AddContact(string path)
        {
            Console.WriteLine("WHAT IS THE FULL NAME OF THE CONTACT? ");
            string? fullName = Console.ReadLine();
            while (string.IsNullOrEmpty(fullName.Trim()))
            {
                Console.WriteLine("PLEASE ENTER A VALID FULL NAME: ");
                fullName = Console.ReadLine();
            }

            Console.WriteLine("WHAT IS THE TELEPHONE NUMBER OF THE CONTACT? (11 digit) ");
            string? telephoneNumber = Console.ReadLine();
            while (telephoneNumber.Length != 11 || !telephoneNumber.All(char.IsDigit))
            {
                Console.WriteLine("PLEASE ENTER A VALID 11 DIGIT TELEPHONE NUMBER: ");
                telephoneNumber = Console.ReadLine();
            }
            telephoneNumber = $"+{telephoneNumber}";

            Console.WriteLine("WHAT IS THE EMAIL OF THE CONTACT? ");
            string? email = Console.ReadLine();
            while (!Regex.IsMatch(email, @"^.+@.+\..+$"))
            {
                Console.WriteLine("PLEASE ENTER A VALID EMAIL ADDRESS:");
                email = Console.ReadLine();
            }

            using (StreamWriter sw = new StreamWriter(path, append: true))
            {   
                sw.WriteLine();
                sw.WriteLine("BEGIN:VCARD");
                sw.WriteLine("VERSION:4.0");
                sw.WriteLine($"FN:{fullName}");
                sw.WriteLine($"TEL:{telephoneNumber}");
                sw.WriteLine($"EMAIL:{email}");
                sw.WriteLine("END:VCARD");
            }
        }
    }
}