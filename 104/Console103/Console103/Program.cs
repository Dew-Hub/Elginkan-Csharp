class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(kokdurumu(1,2,1));
        Console.Read();
    }

    static string kokdurumu(int a, int b, int c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c;
        Console.WriteLine(kokler(a,b,c,delta));
        if (delta > 0) { return ("Kökler Çifttir"); }
        else if (delta == 0) { return ("Kökler çift ve eşittir"); }
        else return ("Kökler sanaldır");
    }

    static string kokler(int a, int b, int c, double delta) 
    { 
        double birinci_kok = -b + Math.Sqrt(delta);
        double ikinci_kok = -b - Math.Sqrt(delta);
        return ($"{birinci_kok}, {ikinci_kok}");
    }

}