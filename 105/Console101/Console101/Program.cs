
class Program
{
    static void Main(string[] args)
    {
        Arac toyota = new Arac();
        toyota.Aracisim = "Toyota";
        toyota.AracModel = "Corolla";
        toyota.renk = "Beyaz";
        toyota.AracYas = 5;
        toyota.km = 40000;
        toyota.Segment = 'C';
        toyota.SasiNo = "CV34324HJH41JSSA";

        toyota.AracBilgileriGöster();
        Console.WriteLine();


        Arac taylan = new Arac();
        toyota.Aracisim= "Taylan";
        toyota.AracModel = "At";
        toyota.renk = "Kahverengi";
        toyota.AracYas = 1;
        toyota.km = 4153634;
        toyota.Segment = 'S';
        toyota.SasiNo = "AT415KFDEM25326GL";

        toyota.AracBilgileriGöster();
        Console.Read();
    }
}
class Arac
{
    public string Aracisim;
    public string AracModel;
    public string renk;
    public byte AracYas;
    public int km;
    public char Segment;
    public string SasiNo;
    public void AracBilgileriGöster()
    {
        Console.Write("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n", Aracisim,AracModel,renk,AracYas,km, Segment,SasiNo);

    }
}