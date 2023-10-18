class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Arayüz seçimi...");
        Console.WriteLine("USB-->1\nAğ Kartı-->2\nEkran Kartı-->3");
        Console.Write("Açılış düğmesine basılsın mı? (E/H) : ");
        int acik = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("-----------------------------------------");


        switch (acik)
        {
            case 'E':
            case 'e':
                {
                    Bilgisayar b = new Bilgisayar();
                    b.AnakartDevreyeGirsin();
                    Console.WriteLine("Ekran kartı devreye girecek...");
                    Console.WriteLine("-----------------------------------------");

                    Console.WriteLine("Ekran kartı bağlantı türünü seçiniz.");
                    Console.WriteLine("HDMI için --> 1");
                    Console.WriteLine("VGA için --> 2 ");
                    Console.WriteLine("DVI için --> 3");
                    Console.Write("Seçiminiz: ");
                    byte secim = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("-----------------------------------------");

                    switch (secim)
                    {
                        case 1:
                            {
                                Console.WriteLine("HDMI bağlantı...");
                                b.HDMIBaglantiYap();
                                Console.WriteLine("Monitör açılıyor...");
                                b.GoruntuOlustur();

                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("VGA bağlantı...");
                                b.VGABaglantiYap();
                                Console.WriteLine("Monitör açılıyor...");
                                b.GoruntuOlustur();
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("DVI bağlantı...");
                                b.DVIBaglantiYap();
                                Console.WriteLine("Monitör açılıyor...");
                                b.GoruntuOlustur();
                                break;
                            }
                        default:
                            Console.WriteLine("Ekran kartını kontrol edin...");
                            break;
                    }

                    break;
                }
            case 'H':
            case 'h':
                Console.WriteLine("Bilgisayar kapalı..."); break;


            default:
                Console.WriteLine("Elektrik sistemini kontrol ediniz...");
                break;
        }
        Console.Read();

    }
}
enum BaglantiTurleri
{
    USB, HDMI, VGA, DVI
}
interface IAnakart
{
    void AnakartDevreyeGirsin();

}
interface IUSB
{
    void VeriGirisYap();
    void VeriCikisYap();
}
interface IAgkarti
{
    void BaglantiKur();
    void BaglantiKapat();
    void BAglantiDevam();
}

interface IEkranKarti
{

    void HDMIBaglantiYap();
    void VGABaglantiYap();
    void DVIBaglantiYap();
}
interface IMonitor
{
    void GoruntuOlustur();
}

class Bilgisayar : IUSB, IEkranKarti, IAgkarti, IAnakart, IMonitor
{
    public void AnakartDevreyeGirsin()
    {
        Console.WriteLine("Anakart devreye giriyor...");
        Console.WriteLine("Arayüz seçiliyor...");
    }

    public void BAglantiDevam()
    {
        Console.WriteLine("Bağlantıya devam...");
    }

    public void BaglantiKapat()
    {
        Console.WriteLine("Bağlantı kapat...");
    }

    public void BaglantiKur()
    {
        Console.WriteLine("Bağlantı kuruluyor...");
    }

    public void DVIBaglantiYap()
    {
        Console.WriteLine("DVI bağlantı kuruldu...");
    }

    public void GoruntuOlustur()
    {
        Console.WriteLine("Ekranda görüntü oluşuyor...");
    }

    public void HDMIBaglantiYap()
    {
        Console.WriteLine("HDMI bağlantı kuruldu...");
    }



    public void VeriCikisYap()
    {
        Console.WriteLine("Veri aktarılıyor...");
    }

    public void VeriGirisYap()
    {
        Console.WriteLine("Veri alınıyor...");
    }

    public void VGABaglantiYap()
    {
        Console.WriteLine("VGA bağlantısı kuruldu...");
    }
}