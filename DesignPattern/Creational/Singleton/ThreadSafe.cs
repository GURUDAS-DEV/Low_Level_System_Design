class ThreadSafe
{
    private static ThreadSafe? instance;
    private static readonly object lockObj = new object();

    private ThreadSafe() { }

    public static ThreadSafe GetInstance()
    {
        lock (lockObj)
        {
            if (instance == null)
            {
                Console.WriteLine("Object Created Successfully");
                instance = new ThreadSafe();
            }
            Console.WriteLine("Already Created Object is returned");
            return instance;
        }

    }

}