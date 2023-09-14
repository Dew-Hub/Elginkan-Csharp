byte yas;
string medeni_durum;

Console.Write("Yaş: ");
yas = byte.Parse(Console.ReadLine());

if (yas >= 18)
{
    Console.Write("Medeni durum?: ");
    medeni_durum = Console.ReadLine();
    medeni_durum = medeni_durum.ToUpper();
    if (medeni_durum == "BEKAR")
    {
        Console.WriteLine("Evliliğe elverişlidir...");
    }

    else if (medeni_durum == "EVLİ")
    {
        Console.WriteLine("Evliliğe elverişli değildir...");
    }
    else
        Console.WriteLine("Evli veya Bekar olarak giriş yapınız!");
}

else if (yas < 18)
{
    Console.WriteLine("Evliliğe elverişli değildir...");
}

else
{
    Console.WriteLine("Evliliğe elverişli değildir...");
}

Console.Read();


int leng = 10;
int say = 1;
for (int b = 0; b < leng; b++)
{
    Console.WriteLine();
    for (int i = 0; i <= say; i++)
    {
        Console.Write('*');
        
    }
    say++;
}
for (int b = 0; b < leng; b++)
{
    Console.WriteLine();
    for (int i = 0; i <= say; i++)
    {
        Console.Write('*');

    }
    say--;
}