public class Email
{
    public string? To { get; }
    public string? Subject { get; }
    public string? CC { get; }
    public string? BCC { get; }
    public string? Body { get; }
    public string? Priority { get; }
    public string? Attachment { get; }

    private Email(Builder builder)
    {
        To = builder.To;
        Subject = builder.Subject;
        CC = builder.CC;
        Body = builder.Body;
        Priority = builder.Priority;
        Attachment = builder.Attachment;
    }

    public override string ToString()
    {
        return $"Email{{to='{To}', subject='{Subject}', cc=[{string.Join(", ", CC)}], bcc=[{string.Join(", ", BCC)}], body='{Body}', priority='{Priority}', attachments=[{string.Join(", ", Attachment)}]}}";

    }

    public class Builder
    {
        public string? To { get; }
        public string? Subject { get; }
        public string? CC { get; private set; }
        public string? BCC { get; private set; }
        public string? Body { get; private set; }
        public string? Priority { get; private set; }
        public string? Attachment { get; private set; }

        public Builder()
        {
            Console.WriteLine("Builder invoked");
        }

        public Builder(string To, string Subject)
        {
            this.To = To;
            this.Subject = Subject;
        }

        public Builder SetCC(string CC)
        {
            this.CC = CC;
            return this;
        }
        public Builder SetBCC(string BCC)
        {
            this.BCC = BCC;
            return this;
        }
        public Builder SetBody(string Body)
        {
            this.Body = Body;
            return this;
        }
        public Builder SetPriority(string Priority)
        {
            this.Priority = Priority;
            return this;
        }
        public Builder SetAttachment(string Attachment)
        {
            this.Attachment = Attachment;
            return this;
        }

        public Email Build()
        {
            return new Email(this);
        }

    }
}