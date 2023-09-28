class Program
{
    static void Main(string[] args)
    {
        Muhendis mh= new Muhendis();
        mh.GetInfo();
        Console.Read();
    }

}

class Personel
{
    protected string tckimlik = "123456789012";
    protected string isim = "Hasan Deniz";

    public virtual void GetInfo()
    {
        Console.WriteLine("İsim: "+isim);
        Console.WriteLine("Türkiye Cumhuriyeti Kimlik Numarası: "+tckimlik);
    }
}

class Muhendis : Personel
{
    public string diplomaNo = "23532";
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine("Diploma No: "+diplomaNo);
    }

}