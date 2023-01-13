public class Person
{
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Person)
        {
            var p = (Person) obj;
            return p.Age == Age &&
                p.FirstName == FirstName &&
                p.LastName == LastName;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return 31 * FirstName.GetHashCode() * LastName.GetHashCode() * Age.GetHashCode();
    }
}

// With positional syntax, resulting record type is immutable
public record PersonR(string FirstName, string LastName, int Age);

// a mutable record, what is the benefit?
// inbuilt ToString, Equals, GetHashCode, Deconstruct implementations
public record PersonRM
{
    public PersonRM(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

// Nested Record Types
public record Relation(PersonR Subject, PersonR Other, string Relationship);