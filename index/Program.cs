//index of

/*

//cria uma string com uma mensagem entre parenteses
string message = "Find what is (inside the parentheses)";

cria uma variável que usa o IndexOf pra definir onde começa a posição que queremos
int openingPosition = message.IndexOf('(');
cria uma variável que usa o IndexOf pra definir onde acaba a posição que queremos
int closingPosition = message.IndexOf(')');

//Console.WriteLine(openingPosition);
//Console.WriteLine(closingPosition);

//adiciona mais um na posição inicial pra pegar o início da frase entre parenteses
openingPosition += 1;

calcula o tamanho fazendo o fim menos o início
int lenght = closingPosition - openingPosition;
joga pra uma string a mensagem exibindo o que está na posição inicial no tamanho calculado
Console.WriteLine(message.Substring(openingPosition, lenght));
*/

//parte 2

/*
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int lenght = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, lenght));
*/

//parte 3

/*
string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
*/

//parte 4

/*
string message = "(What if) there are (more than) one (set of parentheses)?";
while(true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    message = message.Substring(closingPosition +1);
}
*/

//parte 5

/*
string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '('};
int startPosition = 6;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");
*/

//parte 6

/*
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

char[] openSymbols = { '[', '{', '(' };

int closingPosition = 0;

while(true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    int lenght = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, lenght));
}
*/

//Remove()

/*
string data = "12345John Smith          5000 3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);
*/

//Replace()

/*
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
*/

//