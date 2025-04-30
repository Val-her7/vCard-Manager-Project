using System;
using System.IO;

namespace VcardManager.Services
{
    public class ReadFile
    {
        public static void ReadAllLines()
        {
            string path = "contacts.vcf";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string? ligne;
                    if ((ligne = sr.ReadLine()) == null)
                    {
                        Console.WriteLine("Empty File.");
                    }
                    while ((ligne = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(ligne);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
            }
        }
    }
}