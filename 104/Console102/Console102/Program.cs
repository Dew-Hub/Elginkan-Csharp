using System;

class Program
{
    static void Main(string[] args)
    {
        metot();
    }
    static void metot()
    {
        int x1, x2, y1, y2;

        while (true)
        {
            Console.Write("x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            if (x1 == 0)
            {
                Console.WriteLine("Sifirdan farkli");
                continue;
            }
            break;
        }
        while (true)
        {
            Console.Write("y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            if (y1 == 0)
            {
                Console.WriteLine("Sifirdan farkli");
                continue;
            }
            break;
        }
        while (true)
        {
            Console.Write("x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            if (x2 == 0)
            {
                Console.WriteLine("Sifirdan farkli");
                continue;
            }
            break;
        }
        while (true)
        {
            Console.Write("y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            if (y2 == 0)
            {
                Console.WriteLine("Sifirdan farkli");
                continue;
            }
            break;
        }
        double s = uzaklikhesapla(x1, y1, x2, y2);
        if (s < 0)
            Math.Abs(s);
        Console.WriteLine("{0},{1} ve {2},{3} noktarlarının uzaklığı = {4}", x1, x2, y1, y2, s);

    }
    public static double uzaklikhesapla(int x1, int y1, int x2, int y2)
    {
        double mt = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        return mt;

    }
}