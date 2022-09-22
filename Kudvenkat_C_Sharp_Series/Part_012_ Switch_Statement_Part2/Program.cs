int totalCoffeeCost = 0;

Start:
int userChoice = 0;
bool isUserChoiceInt;
do
{
    Console.WriteLine("Select your coffee size: 1 for Small, 2 for Medium, 3 for Large. Write an integer form 1 to 3");
    isUserChoiceInt = int.TryParse(Console.ReadLine(), out userChoice);
}while (!isUserChoiceInt);


switch (userChoice)
{ 
    case 1:
        totalCoffeeCost = totalCoffeeCost + 1;
        break;
    case 2:  
        totalCoffeeCost = totalCoffeeCost + 2;
        break;
    case 3:
        totalCoffeeCost = totalCoffeeCost + 3;
        break;
    default:
        Console.WriteLine("Your Choice {0} is invalid", userChoice);
        goto Start;
}

Decide:
Console.WriteLine("Do you want to buy another coffee - Yes or No?");
string? userDecision = Console.ReadLine();

switch (userDecision.ToUpper())
{
    case "YES":
        goto Start;
    case "NO":
        break;
    default:
        Console.WriteLine("Your choice {0} is invalid. Please try again", userDecision);
        goto Decide;

}

Console.WriteLine("Thank you for shopping with us");
Console.WriteLine("Bill amount = {0} ", totalCoffeeCost);


Console.ReadKey();
