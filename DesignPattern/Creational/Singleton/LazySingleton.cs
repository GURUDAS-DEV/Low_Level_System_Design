class LazySingleton
{
    private static LazySingleton? instance;

    private LazySingleton(){ }

    public static LazySingleton GetInstance()
    {
        
        if(instance == null)
        {
            Console.WriteLine("Object Created Successfully");
            instance = new LazySingleton();
            return instance;
        }

        Console.WriteLine("Already Created Object is returned");
        return instance;
    }
}