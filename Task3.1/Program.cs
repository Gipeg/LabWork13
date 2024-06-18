class program
{

static void Main(string[] args)
{
    Console.WriteLine("2:");
    Console.WriteLine("Введите текст:");
    string text = Console.ReadLine();

    string[] words = text.Trim().Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

    foreach (string word in words)
    {
        Console.WriteLine(word);
    }

    Console.ReadLine();
}
}
