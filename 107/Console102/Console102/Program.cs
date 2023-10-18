class Program
{
    static void Main()
    {
      
    }

}

abstract class AkilliTelefonTemelOzellikler
{
    public abstract void FotografCek();
    public abstract void VideoCek();
    public virtual void CocukKilidi()
    {
        Console.WriteLine("Çocuk kilidi aktif...");
    }
    public virtual void GPSIzleme()
    {
        Console.WriteLine("GPS izleme aktif...");
    }
    public void Kapan()
    {
        Console.WriteLine("Kapanıyor...");
    }
}

class AkilliTelefonA: AkilliTelefonTemelOzellikler
{
    public override void FotografCek() 
    {
        Console.WriteLine("Fotoğraf çekme özelliği var...");
    }

    public override void VideoCek() 
    {
        Console.WriteLine("Video çekme özelliği var...");
    }

    public override void CocukKilidi()
    {
        base.CocukKilidi();
    }
    public new void Kapan()
    {

    }
}