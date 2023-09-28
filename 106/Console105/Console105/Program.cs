class Program
{
    static void Main(string[] args)
    {
        Limuzin limu = new Limuzin(200, "Mercedes", 10);
        Console.ReadLine();
    }
}

class Araba 
{
    public int MotorGucu { get; set; }
    public string Marka{ get; set; }

    public Araba(int motorgucu, string marka) 
    { 
        this.MotorGucu = motorgucu;
        this.Marka = marka;
        Console.WriteLine("Marka: {0}\nMotor Gücü: {1}", Marka, MotorGucu);

    }

    
}
class Limuzin : Araba
{
    public int uzunluk { get; set; }
    public Limuzin(int motorgucu, string marka, int uzunluk) : base(motorgucu, marka)
    {
        this.uzunluk = uzunluk;
        Console.WriteLine("Koltuk Sayısı: {0}", uzunluk);
    }

    public override void OzellikGoster()
    {
        base.OzellilGoster();
        Console.WriteLine("Marka: {0}\nMotor Gücü: {1}\nKoltuk Sayısı: {2}", Marka, MotorGucu, uzunluk);
    }
}