public class AddressBook
{
    // Fields
    private readonly List<Contact> _contacts;

    public AddressBook()
    {
        _contacts = new List<Contact>();
    }
    
    public void AddContact(Contact contact)
    {
        _contacts.Add(contact);
    }

    public void RemoveContact(Contact contact)
    {
        _contacts.Remove(contact);
    }

    public void SortContacts()
    {
        _contacts.Sort();
    }

    public void PrintContacts()
    {
        foreach (var item in _contacts)
        {
            Console.WriteLine(item);
        }
    }

    public Contact GetContact(string firstName, string lastName)
    {
        return null;
    }

    
}
