
class Program
{
    static void Main(string[] args)
    {
        DenizAraci da = new DenizAraci();

        da.araccinsi = "Motoryat";
        da.agirligi = 5000;
        da.hizi = 20;

        Console.Read();

    }
}


class DenizAraci
{
    public string araccinsi;
    public int agirligi;
    public byte hizi;

    public void HizGoster()
    {
        Console.WriteLine(hizi);
    }

}