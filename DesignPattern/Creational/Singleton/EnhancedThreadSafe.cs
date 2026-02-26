class EnhancedThread
{
    private static EnhancedThread? instance;
    private readonly static Object obj = new object();

    private EnhancedThread(){}

    public EnhancedThread GetInstance()
    {
        if(instance == null)
        {
            lock(obj){
                if(instance == null)
                {
                    instance = new EnhancedThread();
                }
            }
        }

        return instance;
    }
}