using System.Data;
using System.Linq.Expressions;

Random random = new();
int daysUntilExpiration = random.Next(12);
int descountPorcentage = 0;

//daysUntilExpiration = 5;

if (daysUntilExpiration == 0)
{
    Console.WriteLine($"Your subscription has expired");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine($"Your subscription expires within a day!");
    descountPorcentage = 20;
    Console.WriteLine($"Renew now and save {descountPorcentage}%");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    descountPorcentage = 10;
    Console.WriteLine($"Renew now and save {descountPorcentage}%!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else
{
    Console.WriteLine(" ");
}