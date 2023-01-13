// Optional chaining of constructors
public class ItemWithId
{
    private static int _lastId;
    private int _id;
    private string? _name;

    public ItemWithId()
    {
        _id = ++_lastId;
    }

    public ItemWithId(string name)
        : this()
    {
        _name = name;
    }

    public ItemWithId(string name, int id)
    {
        _name = name;
        _id = id;
    }
}

// Chained constructor arguments
public class ItemWithIdX
{
    private static int _lastId;
    private int _id;
    private string? _name;

    public ItemWithIdX() : this(null)
    {
    }

    public ItemWithIdX(string? name) : this(name, ++_lastId)
    {
    }

    public ItemWithIdX(string? name, int id)
    {
        _name = name;
        _id = id;
    }
}