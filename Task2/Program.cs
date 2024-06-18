using System.Text;

class program
{
    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        string userInput = Console.ReadLine();

        string trimmedString = userInput.Trim();
        string normalizedString = System.Text.RegularExpressions.Regex.Replace(trimmedString, @"\s+", " ");

        Console.WriteLine("Изменённая строка(без лишних пробелов)" + normalizedString);

        Console.WriteLine("Введите регистр для изменения(верхний В, нижний - Н, инвертированный - И)");

        char choice = Console.ReadLine()[0];
        
        StringBuilder modifiedString = new StringBuilder();

        switch (Char.ToUpper(choice))
        {
            case 'B':
                modifiedString.Append(userInput.ToUpper());
                break;
            case 'Н':
                modifiedString.Append(userInput.ToLower());
                break;
            case 'И':
                for (int i = 0; i < userInput.Length; i++)
                {
                    if (Char.IsLower(userInput[i]))
                    {
                        modifiedString.Append(char.ToUpper(userInput[i]));
                    }
                    else
                    {
                        modifiedString.Append(char.ToLower(userInput[i]));
                    }
                }
                break;
            default:
                Console.WriteLine("Неверный выбор");
                return;
        }
        Console.WriteLine("Измененнная строка: " + modifiedString);
    }
}
