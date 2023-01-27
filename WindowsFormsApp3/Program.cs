using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "C:\\Users\\Intrus1ve\\Desktop\\a.txt";
        string searchPattern = @"";
        string outputFile = "C:\\Users\\Intrus1ve\\Desktop\\b.txt";

        string text = File.ReadAllText(filePath);
        MatchCollection matches = Regex.Matches(text, searchPattern);

        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            foreach (Match match in matches)
            {
                writer.WriteLine(match.Value);
            }
        }
    }
}
