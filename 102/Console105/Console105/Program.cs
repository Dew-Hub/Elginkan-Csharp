int istenen;

Console.WriteLine("  **************");
Console.WriteLine(" *ALAN HESAPLAMA*");   
Console.WriteLine("*******************");
Console.WriteLine("*  1) Kare        *" +
                "\n*  2) Dikdörtgen  *" +
                "\n*  3) Daire       *");
Console.WriteLine("*******************");


Console.Write("Yapılmak istenen işlem?: ");
istenen = int.Parse(Console.ReadLine());
Console.Clear();

if (istenen == 1)
{
    Console.Write("Kenar: ");
    double kenar = double.Parse(Console.ReadLine());
    Console.WriteLine("Kenarı: {0}\nAlanı: {1}",kenar, (kenar * kenar));
}

else if (istenen == 2)
{
    Console.Write("Uzun Kenarı: ");
    double uzunkenar = double.Parse(Console.ReadLine());
    Console.Write("Kıza Kenarı: ");
    double kisakenar = double.Parse(Console.ReadLine());
    Console.WriteLine("Uzun kenarı: {0}\nKısa Kenarı: {1}\nAlanı: {2}", uzunkenar,kisakenar,(uzunkenar * kisakenar));
}

else if (istenen == 3)
{
    Console.Write("Yarı çap: ");
    double yaricap= double.Parse(Console.ReadLine());
    Console.WriteLine("Yarı çap: {0}\nAlan: {1}", yaricap, (Math.PI * yaricap * yaricap));
}

else
{
    Console.WriteLine("Yanlış seçim yaptınız.");
}
Console.Read();