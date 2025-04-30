using System;
using System.IO;

namespace VcardManager.Services
{
    public class ReadFile
    {
        public static void ReadAllLines()
        {
            string path = "contacts.vcf";
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string? ligne;
                    if((ligne = sr.ReadLine()) == null){
                        Console.WriteLine("Empty File.");
                    }
                    while ((ligne = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(ligne);
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}