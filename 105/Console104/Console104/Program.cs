class Program
{ 

    static void Main(string[] args)
    {
        Hesapla hes = new Hesapla();
        hes.sayi1 = 2;
        hes.sayi2 = 5;
        Console.WriteLine(hes.topla());
        Console.WriteLine(hes.topla2(10,25));
        Hesapla hes2 = new Hesapla(20, 22);
        Console.Read();
    }
}

class Hesapla
{
    public int sayi1;
    public int sayi2;
    public int sayi3;
    public int sayi4;


    public Hesapla()
    {   }
    public Hesapla(int sayi5, int sayi6)
    {
        this.sayi3 = sayi5;
        this.sayi4 = sayi6;
        Console.WriteLine(sayi3 + sayi4);

    }
    public int topla()
    {
        return sayi1 + sayi2;
    }

    public int topla2(int a, int b)
    {
        return a + b;
    }

}