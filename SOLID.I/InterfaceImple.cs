interface IPrintable
{
    void Print(string document);
}

interface IScanable
{
    void Scan(string document);
}

interface IFaxable
{
    void Fax(string document);
}

interface IStaple
{
    void Staple(string document);
}