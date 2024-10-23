using System;
using System.Linq;

public class Program
{
    public static string SpinWords(string sentence)
    {
        return string.Join(" ", sentence.Split(' ').Select(word => word.Length >= 5 ? new string(word.Reverse().ToArray()) : word));
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(SpinWords("Hey fellow warriors"));
        Console.WriteLine(SpinWords("This is a test"));
        Console.WriteLine(SpinWords("This is another test"));
    }
}