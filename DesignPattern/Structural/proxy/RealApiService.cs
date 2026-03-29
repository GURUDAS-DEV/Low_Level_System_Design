class RealApiService : IApiService
{
    public string Request(string endpoint) => $"Request from {endpoint}";
}