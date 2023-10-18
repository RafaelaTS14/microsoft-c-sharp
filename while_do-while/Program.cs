/*Random random = new Random();
int current = random.Next(1, 11);


do
{
    current = random.Next(1, 11);

    if (current >= 8)
    {
        continue;
    }

    Console.WriteLine(current);

} while (current != 7);



while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

//desafio

/*

Random random = new Random();
int Monster = 10;
int Hero = 10;
int ataque = random.Next(1, 10);

while (Monster > 0 || Hero > 0)
{
    ataque = random.Next(1, 10);
    Monster -= ataque;
    Console.WriteLine($"O monstro sofreu dano e perdeu {ataque} Pontos de Vida! Agora ele possui {Monster} Pontos de Vida.");

    if (Monster <= 0) break;

    ataque = random.Next(1, 10);
    Hero -= ataque;
    Console.WriteLine($"O monstro sofreu dano e perdeu {ataque} Pontos de Vida! Agora ele possui {Hero} Pontos de Vida.");

    if (Hero <= 0) break;
}

if (Hero > 0)
{
    Console.WriteLine("O Herói venceu!");
}
else
{
    Console.WriteLine("O Monstro venceu!");
}
*/

//segundo desafio

/*
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        valueEntered = readResult;
    }
    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please, enter a number between 5 and 10");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();
*/

//terceiro desafio

/*
string? readResult;
string roleName = "";
string[] roleNames = { "administrador", "gerente", "usuario" };
bool validResponse = false;
string novaEntrada = "";

Console.WriteLine("Por favor, digite sua função:");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        roleName = readResult;
    }

    novaEntrada = roleName.ToLower().Trim();

    if (!roleNames.Contains(novaEntrada))
    {
        validResponse = false;
        Console.WriteLine($"{roleName} não é uma função válida. Por favor, digite novamente: ");
    }
    else
    {
        validResponse = true;
    }
} while (validResponse == false);

Console.WriteLine($"Sua função de {roleName} foi aceita.");
readResult = Console.ReadLine();
*/

//desafio 4

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf('.');

    string mySentence;

    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1);

        myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}