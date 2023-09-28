class Program
{
    static void Main(string[] args)
    {
        A2 a2 = new A2();
        A2 a22= new A2("Girdi");
        Console.Read();
    }
}

class A1
{
    public A1()
    {
        Console.WriteLine("A2 nesnesinden a2 oluştuğunda base ifadesinden dolayı ekrana yazıldı...");
    }
    public A1(string x)
    { 
        Console.WriteLine("A2 nesnesinden a22 oluştuğunda parametreli base ifadesinden dolayı ekrana yazıldı...");
    }
}

class A2 : A1
{ 

    public A2() : base() { }
    public A2(string x) : base(x) { }
}