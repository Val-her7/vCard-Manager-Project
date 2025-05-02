namespace VcardManager
{
    public class DisplayContacts
    {
        public static void DisplayAll(List<string> lines)
        {
            Contact? current = null;
            foreach (string line in lines)
            {
                if (line.StartsWith("BEGIN:VCARD"))
                {
                    current = new Contact();
                }
                else if (line.StartsWith("FN:") && current != null)
                {
                    current.FullName = line.Substring(3);
                }
                else if (line.StartsWith("TEL:") && current != null)
                {
                    current.TelephoneNumber = line.Substring(4);
                }
                else if (line.StartsWith("EMAIL:") && current != null)
                {
                    current.Email = line.Substring(6);
                }
                else if (line.StartsWith("END:VCARD") && current != null)
                {
                    Console.WriteLine(current.ToString());
                    current = null;
                }
            }
        }

        public static void DisplayOne(List<string> lines, string fullName)
        {
            Contact? current = null;
            foreach (string line in lines)
            {
                if (line.StartsWith("BEGIN:VCARD"))
                {
                    current = new Contact();
                }
                else if (line.StartsWith("FN:") && current != null)
                {
                    current.FullName = line.Substring(3);
                }
                else if (line.StartsWith("TEL:") && current != null)
                {
                    current.TelephoneNumber = line.Substring(4);
                }
                else if (line.StartsWith("EMAIL:") && current != null)
                {
                    current.Email = line.Substring(6);
                }
                else if (line.StartsWith("END:VCARD") && current != null)
                {
                    if(current.FullName.ToLower() == fullName.ToLower()){
                        Console.WriteLine(current.ToString());
                        return;
                    }
                }
            }
            Console.WriteLine("THIS CONTACT ISN'T REGISTRED");
        }
    }
}