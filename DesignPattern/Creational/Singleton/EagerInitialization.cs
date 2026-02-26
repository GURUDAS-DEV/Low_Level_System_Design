class EagerIntialization
{
    private readonly static EagerIntialization instance = new EagerIntialization();

    private EagerIntialization() {}

    public static EagerIntialization GetInstance()
    {
        return instance;
    }
}