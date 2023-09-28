class Program
{
    static void Main(string[] args)
    {
        hesapla.topla(4,47);
        hesapla.carp(4,4);
        hesapla.cikar(64,23);
        hesapla.bol(32,5);
    }
}
public static class hesapla
{
    public static void topla(int sayi1, int sayi2)
    { 
        int toplam = sayi1 + sayi2;
        Console.WriteLine("Toplama: "+toplam);
    }
    public static void carp(int sayi1, int sayi2)
    {
        int carpim = sayi1 * sayi2;
        Console.WriteLine("Çarpım: "+carpim);

    }
    public static void cikar(int sayi1, int sayi2)
    {
        int fark = sayi1 - sayi2;
        Console.WriteLine("Çıkartma: "+fark);
    }
    public static void bol(int sayi1, int sayi2)
    {
        int bolum= sayi1 / sayi2;
        Console.WriteLine("Bölme: "+bolum);
    }
}