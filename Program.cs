using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "plikZadania.txt";

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                char[] characters = line.ToCharArray();
                Array.Reverse(characters);

                Console.WriteLine(new string(characters));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd: " + ex.Message);
        }
    }
}