class program
{
    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        string userInput = Console.ReadLine();

        Console.WriteLine("Количество символов в строке: " + userInput.Length);

        int numCharacterNoSpaces = userInput.Replace(" ", "").Length;
        Console.WriteLine("Количество символов без учёта пробелов: " + numCharacterNoSpaces);

        int numLetters = 0;
        for (int i = 0; i < userInput.Length; i++)
        {
            if (char.IsLetter(userInput[i]))
            {
                numLetters++;
            }
        }
        Console.WriteLine("Количество букв в строке: " + numLetters);

        Console.WriteLine("Введите симовол для поиска: ");
        char symbol = Console.ReadLine()[0];

        bool symbolFound = false;

        for (int i = 0; i < userInput.Length; i++)
        {
            if (userInput[i] == symbol)
            {
                symbolFound = true;
                Console.WriteLine("Позиция символа (без учёта пробела)'" + symbol + "': " + i);
            }
        }

        if(!symbolFound)
        {
            Console.WriteLine("Символ '" + symbol + "' не найден во введённой строке");
        }
    }
}
