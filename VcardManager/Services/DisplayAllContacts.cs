namespace VcardManager
{
    public class DisplayAllContacts
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
                    current.FirstName = line.Substring(3);
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
    }
}