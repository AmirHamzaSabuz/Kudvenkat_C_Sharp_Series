
int userTarget = 0;
bool isUserTargetInt;

do
{
    Console.WriteLine("Please enter your target integer number to get the even numbers");
    isUserTargetInt = int.TryParse(Console.ReadLine(), out userTarget);
} while (!isUserTargetInt);

int i = 0;
Console.Write("Even numbers are: ");
while (i <= userTarget)
{
    Console.Write(i + ", ");
    i = i + 2;
}
Console.WriteLine();
Console.WriteLine();



int userTarget2 = 0;
bool isUserTarget2Int;
do
{
    Console.WriteLine("Please enter your target integer number to get the odd numbers");
    isUserTarget2Int = int.TryParse(Console.ReadLine(), out userTarget2);
} while (!isUserTarget2Int);

int j = 1;
Console.Write("Odd numbers are: ");
while (j <= userTarget2)
{
    Console.Write(j + ", ");
    j = j + 2;
}
Console.WriteLine();

Console.ReadKey();

