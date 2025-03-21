Console.Clear();
Console.ResetColor();
string[] petData = new string[5];
DisplayHeader();
petData[0] = GetInput("Espécie (ex: CÃO, GATO, etc.): ");
petData[1] = GetInput("Raça (se desconhecida, digite INDEFINIDA): ");
petData[2] = GetInput("Alcunha (nome do pet): ");
petData[3] = GetAgeInput("Idade (em anos): ");
petData[4] = GetInput("Cor (pelagem do pet): ");

Pet newPet = new Pet(petData[0], petData[1], petData[2], int.Parse(petData[3]), petData[4]);
newPet.ShowPet();
static void DisplayHeader()
{
    Console.WriteLine("+=========================================================+");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("|                 Pet Hotel \"Nem um pio\"                  |");
    Console.ResetColor();
    Console.WriteLine("+=========================================================+");
}

static string GetInput(string prompt)
{
    string input;
    do
    {
        Console.Clear();
        DisplayHeader();
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
        Console.Clear();
        DisplayHeader();
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
        Console.WriteLine("+=========================================================+");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"| Espécie: {Species.PadLeft(15, '.')} | Raça: {Breed.PadLeft(15, '.')} |");
        Console.ResetColor();
        Console.WriteLine("+=========================================================+");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"| Atende pela alcunha {Nickname.PadLeft(30, '.')} |");
        Console.WriteLine($"| Idade: {Age.ToString().PadLeft(15, '.')} ano(s) | Pelagem/cor: {Color.PadLeft(15, '.')} |");
        Console.ResetColor();
        Console.WriteLine("+=========================================================+");
    }
}