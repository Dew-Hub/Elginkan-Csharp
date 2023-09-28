class Program
{
    static void Main(string[] args)
    {
        Kitap ktp = new Kitap();
        ktp.renk = "Kırmızı";
        ktp.marka = "Elma";
        ktp.kitapismi = "Süper Can";
        ktp.yazarismi = "Burak";
        ktp.isbn = "2454636457547";
        ktp.GosterBaseBilgileri();
        Console.WriteLine("**************");
        ktp.KitapBilgileri();
        Console.ReadLine();
    }
}

public class BaseClass
{
    public string renk;
    public string marka;
    private string serino = "3524324636547457";
    public void SeriNoBelirle()
    {
        serino = "hgjmg141";
    }

    //virtual yaptığımız için override edebiliriz.
    public virtual void GosterBaseBilgileri()
    {
        Console.WriteLine("Renk: {0}", renk);
        Console.WriteLine("Marka: {0}", marka);
        Console.WriteLine("Seri No: {0}", serino);
    }


}

class Kitap : BaseClass
{    
    public string kitapismi;
    public string yazarismi;
    public string isbn;
   

    
    public void KitapBilgileri()
    {
        GosterBaseBilgileri();
        Console.WriteLine("Kitap İsmi: {0}", kitapismi);
        Console.WriteLine("Yazar İsmi: {0}", yazarismi);
        Console.WriteLine("ISBN: {0}", isbn);
    }
    

   
    public override void GosterBaseBilgileri()
    {
        base.GosterBaseBilgileri();
        Console.WriteLine("Kitap İsmi: {0}", kitapismi);
        Console.WriteLine("Yazar İsmi: {0}", yazarismi);
        Console.WriteLine("ISBN: {0}", isbn);
    }
}