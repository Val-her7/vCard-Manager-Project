using System;
using System.IO;

namespace VcardManager.Services
{
    public class ReadFile
    {
        public static List<string> ReadAllLines(string path)
        {
            List<string> lines = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string? line = sr.ReadLine();
                    if (line == null)
                    {
                        lines.Add("Empty file.");
                        return lines;
                    }
                    lines.Add(line);
                    while ((line = sr.ReadLine()) != null)
                    {   
                        lines.Add(line);
                    }
                    return lines;
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"File not found: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
            }
            return lines;
        }
    }
}