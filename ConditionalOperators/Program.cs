// Conditional
// if else ( ==, >, <, >=, <=, != )
Console.Write("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of oranges: ");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());

if (numberOfApples > numberOfOranges)
{
    Console.WriteLine("There are more apples than oranges");
}
else if (numberOfOranges > numberOfApples)
{
    Console.WriteLine("There are more oranges than apples");
}
else if (numberOfApples == numberOfOranges)
{
    Console.WriteLine("Apples and oranges are equal");
}
else
{
    Console.WriteLine("Invalid");
}


// switch
Console.Write("Enter your mark (0-100): ");
int marks = Convert.ToInt32(Console.ReadLine());

switch(marks)
{
    case int n when (n < 50):
        Console.WriteLine("You are failed");
        break;
    case int n when (n >= 50 && n <= 100):
        Console.WriteLine("You are passed");
        break;
    default:
        Console.WriteLine("Invalid input for mark");
        break;
}

// ternary - <condition> ? true action : false action
var message = numberOfApples > numberOfOranges ? "We have more apples" : "We have less apples";
Console.WriteLine(message);