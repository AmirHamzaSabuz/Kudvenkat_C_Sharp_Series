
Console.WriteLine("Please enter your target number to get the even numbers");

int userTarget = 0;

bool isUserTargetInt = int.TryParse(Console.ReadLine(), out userTarget);
while (!isUserTargetInt)
{
    Console.WriteLine("Please enter an interger for target number");
    isUserTargetInt = int.TryParse(Console.ReadLine(), out userTarget);
}
int i = 0;
Console.Write("Even numbers are: ");
while (i <= userTarget)
{
    Console.Write(i + ", ");
    i = i + 2;
}
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Please enter your target number to get the odd numbers");
int userTarget2 = 0;

bool isUserTarget2Int = int.TryParse(Console.ReadLine(), out userTarget2);
while (!isUserTarget2Int)
{
    Console.WriteLine("Please enter an interger for target number");
    isUserTarget2Int = int.TryParse(Console.ReadLine(), out userTarget2);
}
int j = 1;
Console.Write("Odd numbers are: ");
while (j <= userTarget2)
{
    Console.Write(j + ", ");
    j = j + 2;
}
Console.WriteLine();

Console.ReadKey();

