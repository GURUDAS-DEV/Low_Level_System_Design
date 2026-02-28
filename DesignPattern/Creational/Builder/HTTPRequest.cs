using System.Buffers;

class HTTPRequest
{
    public string? Url { get; }
    public string? Method { get; }
    public IReadOnlyDictionary<string, string>? Headers { get; }
    public IReadOnlyDictionary<string, string>? QueryParameter { get; }
    public string? Body { get; }
    public int? Timeout { get; }

    private HTTPRequest(Builder builder)
    {
        Url = builder.Url;
        Method = builder.Method;
        Headers = new Dictionary<string, string>(builder.Headers);
        QueryParameter = new Dictionary<string, string>(builder.QueryParameter);
        Body = builder.Body;
        Timeout = builder.Timeout;
    }

    public override string ToString()
    {
        return $"HttpRequest{{Url='{Url}', Method='{Method}', " +
               $"Headers={Headers?  .Count}, QueryParams={QueryParameter?.Count}, " +
               $"Body='{Body}', Timeout={Timeout}}}";
    }

    public class Builder
    {
        public string? Url { get; }
        public string? Method { get; private set; }
        public Dictionary<string, string> Headers { get; } = new();
        public Dictionary<string, string> QueryParameter { get; } = new();
        public string? Body { get; private set; }
        public int Timeout { get; private set; } = 30000;

        public Builder()
        {
            Console.WriteLine("Invoked!!");
        }
        public Builder(string url)
        {
            Url = url;
        }

        public Builder SetMethod(string method)
        {
            Method = method;
            return this;
        }

        public Builder SetHeaders(string key, string value)
        {
            Headers[key] = value;
            return this;
        }

        public Builder SetQueryParameter(string key, string value)
        {
            QueryParameter[key] = value;
            return this;
        }

        public Builder SetBody(string body)
        {
            Body = body;
            return this;
        }

        public Builder SetTimeout(int Timeout)
        {
            this.Timeout = Timeout;
            return this;
        }

        public HTTPRequest Build()
        {
            return new HTTPRequest(this);
        }
    }

}