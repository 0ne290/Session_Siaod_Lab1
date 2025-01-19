using System.Text;
using ConsoleApplication.Extensions;

namespace ConsoleApplication;

internal static class Program
{
    private static void Main()
    {
        string source;
        Console.Write("Enter path to input file: ");
        try
        {
            var splitedByPoints = File.ReadAllText(Console.ReadLine()!, Encoding.UTF8).Split('.');

            source = splitedByPoints[0];
        }
        catch (Exception)
        {
            Console.WriteLine("Path to book file is invalid.");
            
            Console.Write("To terminate the program, press any key...");
            Console.ReadKey();
            
            return;
        }
        
        var vowels = new Core.Queue<char>();
        var consonants = new Core.Stack<char>();
        foreach (var ch in source)
        {
            if (ch.IsVowel())
                vowels.Enqueue(ch);
            else if (ch.IsConsonant())
                consonants.Push(ch);
            else
            {
                Console.WriteLine($"Unknown character \"{ch}\".");
                
                Console.Write("To terminate the program, press any key...");
                Console.ReadKey();
                
                return;
            }
        }

        var vowelsString = new StringBuilder();
        if (!vowels.IsEmpty())
        {
            while (!vowels.IsEmpty())
                vowelsString.Append($"{vowels.Dequeue()}, ");
            
            vowelsString.Length -= 2;
        }
        
        var consonantsString = new StringBuilder();
        if (!consonants.IsEmpty())
        {
            while (!consonants.IsEmpty())
                consonantsString.Append($"{consonants.Pop()}, ");
            
            consonantsString.Length -= 2;
        }
        
        Console.WriteLine($"Source text: {source}.");
        Console.WriteLine($"Vowels: {vowelsString}.");
        Console.WriteLine($"Consonants: {consonantsString}.");
        
        Console.Write("To terminate the program, press any key...");
        Console.ReadKey();
    }
}