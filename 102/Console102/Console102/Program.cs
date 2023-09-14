double sıcaklık;

sonsuz();

void sonsuz()
{
    Console.Write("\nSıcaklığı giriniz:");
    sıcaklık = Double.Parse(Console.ReadLine());
    


    if (sıcaklık == 0)
        Console.WriteLine("Hava nötr");
    
    else if (sıcaklık < -5)
        Console.WriteLine("Hava aşırı soğuk");

    else if (sıcaklık < 0 && sıcaklık >= -5)
        Console.WriteLine("Hava çok soğuk");
    
    else if (sıcaklık > 0 && sıcaklık <= 10)
        Console.WriteLine("Hava az soğuk");
    
    else if (sıcaklık >= 20 && sıcaklık < 25)
        Console.WriteLine("Hava serin");
    
    else if (sıcaklık >= 25 && sıcaklık < 30)
        Console.WriteLine("Hava sıcak");
    
    else if (sıcaklık >= 30 && sıcaklık < 40)
        Console.WriteLine("Hava çok sıcak");
    
    else
        Console.WriteLine("Hava aşırı sıcak");

    Console.Write("------------------------------");
    sonsuz();
}