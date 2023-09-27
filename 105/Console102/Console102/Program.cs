
class Program
{
    static void Main(string[] args)
    {

        Arac toyota = new Arac("Toyota","Corolla","Beyaz",5,40000,'C',"CV34324HJH41JSSA");
        Console.WriteLine();
        Arac taylan = new Arac("Taylan","At","Kahverengi",1, 4153634, 'S', "AT415KFDEM25326GL");
        Console.Read();

        DenizAraci da = new DenizAraci();

        da.araccinsi = "Motoryat";
        da.agirligi = 5000;
        da.hizi = 20;

        Console.Read();

    }
}
class Arac
{
    public Arac(string Aracisim, string AracModel, string renk, byte AracYas, int km, char Segment, string SasiNo)
    { 
        this.Aracisim = Aracisim;
        this.AracModel = AracModel;
        this.renk = renk;
        this.AracYas = AracYas;
        this.km = km;
        this.Segment = Segment;
        this.SasiNo = SasiNo;
        AracBilgileriGöster();

    }
 
    public string Aracisim;
    public string AracModel;
    public string renk;
    public byte AracYas;
    public int km;
    public char Segment;
    public string SasiNo;
    
    public void AracBilgileriGöster()
    {
        Console.Write("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n", Aracisim, AracModel, renk, AracYas, km, Segment, SasiNo);

    }
}

class DenizAraci
{
    public string araccinsi;
    public int agirligi;
    public byte hizi;

}