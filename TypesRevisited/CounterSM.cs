class CounterSM
{
    private int _count;
    private static int _totalCount;

    public int GetNextValue()
    {
        _count += 1;
        _totalCount += 1;
        return _count;
    }

    // syntax to define the property with a single expression
    public static int TotalCount => _totalCount;
}
