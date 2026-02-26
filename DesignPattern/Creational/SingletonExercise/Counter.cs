class Counter
{
    public static readonly Lazy<Counter> _lazy = new Lazy<Counter>(()=> new Counter());
    private int Count = 0;
    public static Counter Instance => _lazy.Value;

    private Counter(){}

    public void Increment()
    {
        Count++;
    }

    public int GetCounter()
    {
        return Count;
    }
}