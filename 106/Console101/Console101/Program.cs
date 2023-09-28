class Program
{
    static void Main(string[] args)
    {
        A3 a3 = new A3();
        a3.MeslekNedir();
        Console.Read();
    }
}

class A1
{
    public void AdinNe()
    {
        Console.WriteLine("Adınız ne?");
    }
}

class A2 : A1
{
    public void YasinKac()
    {
        Console.WriteLine("Yaşınız kaç?");
        base.AdinNe();
    }
}

class A3 : A2
{
    public void MeslekNedir()
    {
        Console.WriteLine("Mesleğiniz nedir?");
        base.YasinKac();
    }
}