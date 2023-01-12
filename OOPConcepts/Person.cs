// Encapsulation
class Person
{
    public Person(string firstName, string lastName, int age, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        _salary = salary;
    }

    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    // Fields
    private double _salary;

    // Methods
    public void SetSalary(double salary)
    {
        _salary = salary;
    }

    public double GetSalary()
    {
        return _salary;
    }

    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }

    // Method Overloading
    public string GetFullName(string middleName)
    {
        return FirstName + " " + middleName + " " + LastName;
    }
}