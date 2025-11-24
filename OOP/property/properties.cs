class Ex
{
    private string name;
    public string Name
    {
        get{ return name;}
        set{name=value;}
    }
}
class Program
{
    static void Main(string[] args)
    {
        Ex frist = new Ex();
        frist.Name = "Lamia";
        Console.WriteLine(frist.Name);
    }
}