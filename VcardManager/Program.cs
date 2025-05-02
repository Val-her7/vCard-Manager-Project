using VcardManager.Services;

namespace VcardManager
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("WELCOME TO THE VCARD MANAGER CONSOLE APP!");
            while (true)
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine("ENTER 1 TO DISPLAY ALL CONTATCS.");
                Console.WriteLine("ENTER 2 TO ADD A NEW CONTACT.");
                Console.WriteLine("ENTER 3 TO SEARCH FOR A CONTACT BY NAME.");
                Console.WriteLine("ENTER 4 TO DELETE A CONTACT");
                Console.WriteLine("ENTER 5 TO EXPORT A CONTACT INTO A SEPARATE .VCF FILE.");
                Console.WriteLine("ENTER 0 TO EXIT THE APP.");
                Console.WriteLine("*****************************************");
                Console.WriteLine("YOUR CHOICE: ");

                int choice;
                while(!int.TryParse(Console.ReadLine(), out choice)){
                    Console.WriteLine("PLEASE ENTER A NUMBER!");
                }

                string path = "contacts.vcf";
                List<string> lines = ReadFile.ReadAllLines(path);

                switch(choice){
                    case 1:
                        DisplayAllContacts.DisplayAll(lines);
                        break;
                    case 2:
                        AddNewContact.AddContact(path);
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("PLEASE ENTER A VALID CHOICE!");
                        break;
                }
                
            }
        }
    }
}