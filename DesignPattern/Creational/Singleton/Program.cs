class Program
{
    public static void Main()
    {
        // LazySingletonTesting();
        // Console.WriteLine();
        // ThreadSafeSingleton();
        
        EagerIntialization.GetInstance();
    }

    public static void LazySingletonTesting()
    {
        Console.WriteLine("Starting threads...\n");

        Task[] tasks = new Task[20];

        for (int i = 0; i < 20; i++)
        {
            tasks[i] = Task.Run(() =>
            {
                LazySingleton.GetInstance();
            });
        }

        Task.WaitAll(tasks);

        Console.WriteLine("\nFinished execution.");
    }

    public static void ThreadSafeSingleton()
    {
        Console.WriteLine("Starting threads...\n");

        Task[] tasks = new Task[20];

        for (int i = 0; i < 20; i++)
        {
            tasks[i] = Task.Run(() =>
            {
                ThreadSafe.GetInstance();
            });
        }

        Task.WaitAll(tasks);

        Console.WriteLine("\nFinished execution.");
    }
}