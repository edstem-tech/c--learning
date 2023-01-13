// 1. Simple Custom Class
//Console.WriteLine("----------------- Custom Classes -----------------");
//var c1 = new Counter(); // implicit var types using 'var' keyword
//var c2 = new Counter();
//Console.WriteLine("c1: " + c1.GetNextValue()); // c1 _count -> 1, c2 _count -> 0
//Console.WriteLine("c1: " + c1.GetNextValue()); // c1 _count -> 2, c2 _count -> 0
//Console.WriteLine("c1: " + c1.GetNextValue()); // c1 _count -> 3, c2 _count -> 0

//// We get 2 independent counts
//Console.WriteLine("c2: " + c2.GetNextValue()); // c1 _count -> 3, c2 _count -> 1
//Console.WriteLine("c1: " + c1.GetNextValue()); // c1 _count -> 4, c2 _count -> 1

// 2. Static Members
// The static keyword lets us declare that a member is not associated with any
// particular instance of the class
//Console.WriteLine("----------------- Static Members -----------------");
//var cs1 = new CounterSM();
//var cs2 = new CounterSM();
//Console.WriteLine("cs1: " + cs1.GetNextValue()); // cs1 _count -> 1,  CounterSM#_totalCount -> 1
//Console.WriteLine("cs1: " + cs1.GetNextValue()); // cs1 _count -> 2,  CounterSM#_totalCount -> 2
//Console.WriteLine("cs1: " + cs1.GetNextValue()); // cs1 _count -> 3,  CounterSM#_totalCount -> 3
//Console.WriteLine("CSM Total Count : " + CounterSM.TotalCount); // should print 3

//Console.WriteLine("cs2: " + cs2.GetNextValue()); // cs2 _count -> 1,  CounterSM#_totalCount -> 4
//Console.WriteLine("cs1: " + cs1.GetNextValue()); // cs1 _count -> 4,  CounterSM#_totalCount -> 5
//Console.WriteLine("CSM Total Count : " + CounterSM.TotalCount); // should print 5

// ----------------------------------------------------------------------------
// Note: var variables are still all statically typed
// ----------------------------------------------------------------------------

// 3. Static Classes
// compiles the class in a way that prevents instances of it from being constructed
//Console.WriteLine("----------------- Static Classes -----------------");
//Normal.UseStatics();
//WithoutQualification.UseStatics();

//// 4. Records
Console.WriteLine("----------------- Records ------------------------");
var p1 = new Person("Jerrish", "Varghese", 42); 
var p2 = new Person("Jerrish", "Varghese", 42);
var pr1 = new PersonR("Jerrish", "Varghese", 42);
var pr2 = new PersonR("Jerrish", "Varghese", 42);

Console.WriteLine($"Person {p1}");
Console.WriteLine($"Person Record {pr1}");

if (p1.Equals(p2))
{
    Console.WriteLine("Equal method worked for Person class");
}

if (pr1 == pr2)
{
    Console.WriteLine("Equality operator worked for Person record");
}

// pr1.FirstName = "New Name"; // Compilation error because of immutability

// making a modified copy of an immutable record
var pr1Copy = pr1 with
{
    FirstName = "Issac"
};

Console.WriteLine($"Copied Person Record {pr1Copy}");

// Nested record types
var op1 = new PersonR("Joel", "Jerrish", 12);
var op2 = new PersonR("Keziah", "Jerrish", 9);
var r1 = new Relation(pr1, op1, "Son");
Console.WriteLine("Relation 1 is " + r1);

var r2 = new Relation(pr1, op2, "Daughter");
var op3 = new PersonR("Keziah", "Jerrish", 9);
var r3 = new Relation(pr2, op3, "Daughter");
if (r2 == r3)
{
    Console.WriteLine("Relations are equal");
}


//// 5. References and Nulls

//// Any type defined with the class keyword will be a reference type
//// (as will any type declared as record, or the equivalent record class).
//// A variable of any reference type will not contain the data that makes up
//// an instance of the type; instead, it can contain a reference to an
//// instance of the type.
//Console.WriteLine("----------------- References ---------------------");
//var ct1 = new Counter();
//c1.GetNextValue();
//Counter ct2 = ct1;
//var ct3 = new Counter();
//ct3.GetNextValue();

//Console.WriteLine(ct1.Count);
//Console.WriteLine(ct2.Count);
//Console.WriteLine(ct3.Count);
//Console.WriteLine(ct1 == ct2);
//Console.WriteLine(ct1 == ct3);
//Console.WriteLine(ct2 == ct3);
//Console.WriteLine(object.ReferenceEquals(ct1, ct2));
//Console.WriteLine(object.ReferenceEquals(ct1, ct3));
//Console.WriteLine(object.ReferenceEquals(ct2, ct3));

//// check the above with numeric type
//int counter1 = new int();
//counter1++;
//int counter2 = counter1;
//int counter3 = new int();
//counter3++;

//Console.WriteLine(counter1);
//Console.WriteLine(counter2);
//Console.WriteLine(counter3);
//// int type defines a special meaning for ==
//Console.WriteLine(counter1 == counter2);
//Console.WriteLine(counter1 == counter3);
//Console.WriteLine(counter2 == counter3);
//Console.WriteLine(object.ReferenceEquals(counter1, counter2));
//Console.WriteLine(object.ReferenceEquals(counter1, counter3));
//Console.WriteLine(object.ReferenceEquals(counter2, counter3));
//Console.WriteLine(object.ReferenceEquals(counter1, counter1));