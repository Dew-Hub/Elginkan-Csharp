class Program
{
    static void Main(string[] args)
    {
        B b = new B();
        Console.Read();
    }
}

class A
{
    public A()
    {
        Console.WriteLine("Temel sınıf kurucu metodu çalıştı...");
    }
}

class B : A 
{
    public B() 
    {
        Console.WriteLine("Türetilmiş sınıfın kurucu metodu çalıştı...");
    }
}