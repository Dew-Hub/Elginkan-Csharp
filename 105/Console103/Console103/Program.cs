
class Program
{
    static void Main(string[] args)
    {
        nesnegoster();
    }

    public static void nesnegoster()
    {
        DenizAraci da = new DenizAraci();
        da.araccinsi = "Motoryat";
        da.agirligi = 5000;
        da.hizi = 20;
        int hiz = da.HizGoster();
        Console.WriteLine(hiz);
        Console.Read();
    }
}


class DenizAraci
{
    public string araccinsi;
    public int agirligi;
    public byte hizi;

    public byte HizGoster()
    {
        return(hizi);

    }

}