class Program
{
    static void Main(string[] args)
    {
        int x = 1;
        int y;

        Deneme.RefDegerAl(ref x);
        Deneme.OutDegerAl(out y);
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.Read();
    }
}

class Deneme
{ 
    public static void RefDegerAl(ref int x)
    {
        x = 10;
    }

    public static void OutDegerAl(out int y)
    {
        y = 5;
    }
}