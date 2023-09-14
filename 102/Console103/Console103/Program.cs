
tekrarla();

void tekrarla()
{
    Console.Write("a:");
    int a = Convert.ToByte(Console.ReadLine());
    Console.Write("b:");
    int b = Convert.ToByte(Console.ReadLine());
    Console.Write("c:");
    int c = Convert.ToByte(Console.ReadLine());

    int delta = b * b - 4 * a * c;

    if (delta > 0)
        Console.Write("Denklemin birbirinden farklı 2 tane reel kökü vardır");

    else if (delta < 0)
        Console.Write("Denklemin reel bir kökü yoktur");

    else
        Console.Write("Denklemin 1 tane reel kökü vardır");
    tekrarla();
}