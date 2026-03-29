class ProxyRateLimiting : IApiService
{
    Dictionary<string, Queue<DateTime>> RequestRecord = new Dictionary<string, Queue<DateTime>>();
    public string Request(string endpoint)
    {
        if (RequestRecord.ContainsKey(endpoint))
        {
            var Record = RequestRecord[endpoint];
            var CurrentTime = DateTime.Now;
            while(Record.Count > 3)
                Record.Dequeue();

            for(int i=0; i<Record.Count; i++)
            {
                CurrentTime - Record.Peek();
            }
        }
        else
        {
            RequestRecord[endpoint].Enqueue(DateTime.Now);
            RealApiService realApiService = new RealApiService();
            realApiService.Request(endpoint);
        }
        return "";
    }
}