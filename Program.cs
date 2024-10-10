// Console.ForegroundColor = ConsoleColor.White;
// Console.WriteLine("Task One ");
// string firstTask = Console.ReadLine();
// Console.Beep();

// Console.WriteLine("\nTask Second ");
// string SecondTask = Console.ReadLine();
// Console.Beep();

// Console.WriteLine("\nTask Third ");
// string ThirdTask = Console.ReadLine();
// Console.Beep();

// Console.ForegroundColor = ConsoleColor.Red;
// Console.WriteLine($"\n{"1# -".PadRight(5)}| {firstTask}");

// Console.ForegroundColor = ConsoleColor.Yellow;
// Console.WriteLine($"{"2# -".PadRight(5)}| {SecondTask}");

// Console.ForegroundColor = ConsoleColor.Green;
// Console.WriteLine($"{"3# -".PadRight(5)}| {ThirdTask}");

// Console.Beep();
// Console.Beep();
// Console.Beep();

// int a = int.MaxValue;
// int x = byte.MaxValue;

// int absValue = Math.Abs(-150);
// Console.WriteLine(absValue);

// int minValue = Math.Min(10,5);
// int maxValue = Math.Max(10,5);
// Console.WriteLine(minValue + "\n" + maxValue);

// int health = 100;
// health = Math.Clamp(health, 0, 100);
// Console.WriteLine(health);

// Console.Write("Damage: ");
// int health = 100;
// string enterDamage = Console.ReadLine();
// int damage = int.Parse(enterDamage);

// health -= damage;
// health = Math.Clamp(health, 0, 100);
// Console.WriteLine(health);

// Console.Write("healing: ");
// string enterhealing = Console.ReadLine();
// int healing = int.Parse(enterhealing);

// health += healing;
// health = Math.Clamp(health, 0, 100);
// Console.WriteLine(health);


using System.Numerics;

string enterNumOne;
int numOne;

string enterNumTwo;
int NumTwo;

int total;

Console.Write("enter Number One: ");
enterNumOne = Console.ReadLine();
numOne = int.Parse(enterNumOne);

Console.Write("calculator + | - | * | / : ");
string enterCalculator = Console.ReadLine();

Console.Write("enter Number Two: ");
enterNumTwo = Console.ReadLine();
 NumTwo = int.Parse(enterNumTwo);


if(enterCalculator == "+")
{
    total = numOne + NumTwo;
    Console.WriteLine(numOne + " " + enterCalculator + " " + NumTwo + " = " + total);
}
else if (enterCalculator == "-")
{
    total = numOne - NumTwo;
    Console.WriteLine(numOne + " " + enterCalculator + " " + NumTwo + " = " + total);
}
else if (enterCalculator == "*")
{
    total = numOne * NumTwo;
    Console.WriteLine(numOne + " " + enterCalculator + " " + NumTwo + " = " + total);
}
    
else if (enterCalculator == "/")
{
    total = numOne / NumTwo;
    Console.WriteLine(numOne + " " + enterCalculator + " " + NumTwo + " = " + total);
}