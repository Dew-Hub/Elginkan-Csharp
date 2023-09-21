class Program
{
    static void Main(string[] args)
    {
        MyClass2 myc = new MyClass2();
        myc.yap();
    }

}
public class MyClass
{
    public void topla()
    {
        Console.WriteLine(3 + 5);
    }

    void cikar() 
    {
        Console.WriteLine(3 - 5);
    }

    protected void kullan() 
    { 
        cikar();
    }
}

class MyClass2:MyClass
{
    public void yap()
    {
        kullan();
        topla();
    }

}
/*
 * Public: Her yerden ulaşılabilir
 * Private: Sadece tanımlandığı sınıftan ulaşılabilir
 * Protected: Hem tanımlandığı sınıftan hem de miras alan sınıftan ulaşılabilir
 * Internal: Aynı program içinden ulaşılabilir 
 */