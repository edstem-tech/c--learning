class Counter
{
    // Fields
    private int _count;

    // Methods
    public int GetNextValue()
    {
        // notice the 'this' keyword
        // Explicit member access through 'this' is sometimes necessary due to name collisions.
        this._count += 1;
        return _count;
    }

    // Expression implementation for Count property
    public int Count => _count;
}
