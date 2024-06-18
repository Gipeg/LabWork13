using System.Text.RegularExpressions;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1:");
        Console.WriteLine("Введите текст: ");
        string text = Console.ReadLine();
        string[] sentences = Regex.Split(text.Trim(), @"(?<=[.!?])\s+")
            .Select(sentences => sentences.TrimEnd('.', '!', '?'))
            .Where(sentences => !string.IsNullOrEmpty(sentences)).ToArray();

        foreach (string sentence in sentences)
        {
            Console.WriteLine(sentence);
        }
        Console.ReadLine();
    }
}