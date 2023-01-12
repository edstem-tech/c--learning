using System.Globalization;

// Methods
// returnType MethodName(paramType paramName, ...) {}

// DRY - Don't Repeat Yourself
// With no return types
// With return types

//Console.Write("Enter number 1 : ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter number 2: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//void Add(int a, int b)
//{
//    Console.WriteLine($"Addition : {a + b}");
//}

//Add(num1, num2);
//Add(1, 3);

//int GreaterThan(int a, int b, int c)
//{
//    int largest = a;
//    if (b > largest)
//    {
//        largest = b;
//    }
//    if (c > largest)
//    {
//        largest = c;
//    }
//    return largest;
//}

//int largest = GreaterThan(10, 15, 8); // 15
//Console.WriteLine($"Largest number is {largest}");

// String manipulation
// Concatination
//string firstName = "Jerrish";
//string lastName = "Varghese";

//string fullName = firstName + " " + lastName;


//// Length of a string
//int length = firstName.Length;
//Console.WriteLine($"First name has {length} letters");

//// Replace string parts
//string newFirstName = firstName.Replace("rish", "in");
//Console.WriteLine($"New first name is {newFirstName}");

//// Split
//string toSplit = "Jerrish, Mithun, Jerald, Jijo, Tomson";
//string[] names = toSplit.Split(", ");
//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}

//// Compare
//string nullString = null;
//string emptyString = "";
//string whiteSpaceString = " ";

//if (string.IsNullOrEmpty(nullString))
//{
//    Console.WriteLine("nullString is empty or null");
//}

//if (string.IsNullOrWhiteSpace(whiteSpaceString))
//{

//}

////int res = firstName.CompareTo(lastName);
//if (firstName.CompareTo(lastName) == 0)
//{
//    Console.WriteLine("firstName and lastName are equal");
//}

//if (string.Equals(firstName, lastName))
//{

//}

//if (firstName.Equals(lastName))
//{

//}

// DateTime related functionality
// Empty DateTime
//DateTime date = new DateTime();

//// Create DateTime from date
//DateTime dateOfBirth = new DateTime(1980, 1, 25);
//Console.WriteLine($"Date of birth is {dateOfBirth}");

//// Create DateTime from string
//DateTime parsedDate = DateTime.Parse("3/31/2000", CultureInfo.InvariantCulture);
//Console.WriteLine($"Parsed date is {parsedDate}");

//// Create DateTime from current timestamp
//DateTime now = DateTime.Now;
//Console.WriteLine($"Current time is {now}");

//// Date to ticks
//Console.WriteLine($"Ticks for now is  {now.Ticks}");

//// Add hours to DateTime
//Console.WriteLine($"2 hours from now is {now.AddHours(2)}");

//// DateOnly
//DateOnly dob = DateOnly.FromDateTime(dateOfBirth);
//Console.WriteLine(dob);

//// TimeOnly
//TimeOnly tob = TimeOnly.FromDateTime(dateOfBirth);
//Console.WriteLine(tob);

// Exception Handling
//Console.Write("Enter number 1 : ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter number 2: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//try
//{
//    double quotient = num1 / num2;
//    Console.WriteLine($"Result is {quotient}");
//}
//catch (DivideByZeroException e)
//{
//    Console.WriteLine($"Illegal operation performed {e.Message}");
//}
//catch (Exception ex)
//{
//    throw ex;
//}
//finally
//{
//    Console.WriteLine("Exited the program");
//}


// Arrays
// initialize a fixed size array
int[] marks = new int[5]; // 0 based index (0-4)

// iterate an array
for (int i = 0; i < marks.Length; i++)
{
    Console.Write("Enter marks : ");
    marks[i] = Convert.ToInt32(Console.ReadLine());
}

// print an array of elements
for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine(marks[i]);
}

string[] names = new string[] { "Jerrish", "Jerald", "Mithun" };

// Lists
List<string> devs = new List<string>();
string dev = string.Empty;

while(!dev.Equals("-1"))
{
    Console.Write("Enter the name of developer: ");
    dev = Console.ReadLine();
    if (!string.IsNullOrEmpty(dev) && !dev.Equals("-1"))
    {
        devs.Add(dev);
    }
}

foreach (string name in devs)
{
    Console.WriteLine(name);
}

// API documentation