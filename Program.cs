Console.Clear();
Console.ResetColor();
string[] petData = new string[5];
DisplayHeader();
petData[0] = GetInput("Espécie (ex: CÃO, GATO, etc.): ");
petData[1] = GetInput("Raça (se desconhecida, digite INDEFINIDA): ");
petData[2] = GetInput("Alcunha (nome do pet): ");
petData[3] = GetAgeInput("Idade (em anos): ");
petData[4] = GetInput("Cor (pelagem do pet): ");
Console.Clear();
DisplayHeader();
Pet newPet = new Pet(petData[0], petData[1], petData[2], int.Parse(petData[3]), petData[4]);
newPet.ShowPet();
static void DisplayHeader()
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("+=========================================================+");
    Console.Write("|                 ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Pet Hotel \"Nem um pio\"");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("                  |");
    Console.WriteLine("+=========================================================+");
    Console.ResetColor();
}
static string GetInput(string prompt)
{
    string input;
    do
    {
        Console.Write(prompt);
        input = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Por favor, insira uma entrada válida!");
        }
        Thread.Sleep(1000);
    } while (string.IsNullOrWhiteSpace(input));
    return input;
}

static string GetAgeInput(string prompt)
{
    string input;
    do
    {
        Console.Write(prompt);
        input = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out _))
        {
            Console.WriteLine("Por favor, insira uma idade válida!");
        }
        Thread.Sleep(1000);
    } while (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out _));
    return input;
}

public class Pet
{
    public string Species { get; set; }
    public string Breed { get; set; }
    public string Nickname { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }
    public Pet(string species, string breed, string nickname, int age, string color)
    {
        Species = species;
        Breed = breed;
        Nickname = nickname;
        Age = age;
        Color = color;
    }

    public void ShowPet()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("+=========================================================+");

        Console.Write("| Espécie: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{Species.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15)}");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(" | Raça: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{Breed.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22)}");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" |");

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("+=========================================================+");

        Console.Write("| Atende pela alcunha de: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{Nickname.Trim().ToUpper().PadLeft(31, '.').Substring(0, 31)}");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" |");

        Console.Write("| Idade: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{Age.ToString().Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ano(s)");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(" | Pelagem/cor: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{Color.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23)}");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" |");

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("+=========================================================+");

        Console.ResetColor();
    }

}