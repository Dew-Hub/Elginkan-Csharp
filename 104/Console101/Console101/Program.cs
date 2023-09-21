using System;
class Program
{
    static void Main(string[] args)
    {
        Kullan.ax();
        Console.WriteLine();
        Kullan.ay("Bu yazı Kullan class'ı içerisindeki metot'u çağırarak yazılmıştır.");
        Console.Read();
    }




}

class Kullan
{

    public static void ay(string yazdir)
    {
        Console.WriteLine(yazdir);

    }

    public static void ax()
    {
        Console.WriteLine("Metot içerisinden yazıldı.");
    }




}