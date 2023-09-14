int girdisayi1;
int girdisayi2;

string tekrarla;
string istenen;

Baslat();


void Baslat()
{
    

    Console.Clear();

    Console.WriteLine("\nHESAP MAKİNESİ");
    Console.WriteLine("----------------");
    Console.WriteLine("1) Toplama");
    Console.WriteLine("2) Çıkarma");
    Console.WriteLine("3) Bölme");
    Console.WriteLine("4) Çarpma");
    Console.WriteLine("----------------");

    Console.Write("Yapılmak istenen işlem: ");
    istenen = Console.ReadLine();

    Console.Clear();

    ifelsekosulu();
}

void switchchasekosulu()
{

    switch (int.Parse(istenen))
    {
        case 1:
            Console.WriteLine("Durum 1");
            break;
        case 2:
            Console.WriteLine("Durum 2");
            break;
        case 3:
            Console.WriteLine("Durum 2");
            break;
        case 4:
            Console.WriteLine("Durum 2");
            break;
       
    }
}
void ifelsekosulu()
{ 
    if (int.Parse(istenen) == 1)
    {


        Console.WriteLine("\nTOPLAMA");
        Console.WriteLine("----------------");

        Console.Write("İlk Sayıyı Giriniz: ");
        string test1 = Console.ReadLine();

        Console.Write("İkinci Sayıyı Giriniz: ");
        string test2 = Console.ReadLine();

        //test1 ve test2 string değişkeninin içerisindeki verileri int değere dönüştürüp toplam değişkeninin içine atıyoruz
        int toplam = int.Parse(test1) + int.Parse(test2);

        Console.WriteLine("Sonuç: " + toplam);

        Console.Write("Tekrar işlem yapmak istiyor musunuz? (Y/N): ");
        tekrarla = Console.ReadLine();

        if (tekrarla == "Y")
            Baslat();
        else;

    }
    else if (int.Parse(istenen) == 2)
    {


        Console.WriteLine("\nÇıkarma");
        Console.WriteLine("----------------");

        Console.Write("İlk Sayıyı Giriniz: ");
        string test1 = Console.ReadLine();

        Console.Write("İkinci Sayıyı Giriniz: ");
        string test2 = Console.ReadLine();

        int toplam = Convert.ToInt32(test1) - Convert.ToInt32(test2);

        Console.WriteLine("Sonuç: " + toplam);

        Console.Write("Tekrar işlem yapmak istiyor musunuz? (Y/N): ");
        tekrarla = Console.ReadLine();

        if (tekrarla == "Y")
            Baslat();
        else;
    }
    else if (int.Parse(istenen) == 3)
    {


        Console.WriteLine("\nBölme");
        Console.WriteLine("----------------");

        Console.Write("İlk Sayıyı Giriniz: ");
        string test1 = Console.ReadLine();

        Console.Write("İkinci Sayıyı Giriniz: ");
        string test2 = Console.ReadLine();

        float toplam = Convert.ToSingle(test1) / Convert.ToSingle(test2);

        Console.WriteLine("Sonuç: " + toplam);

        Console.Write("Tekrar işlem yapmak istiyor musunuz? (Y/N): ");
        tekrarla = Console.ReadLine();

        if (tekrarla == "Y")
            Baslat();
        else;
    }
    else if (int.Parse(istenen) == 4)
    {


        Console.WriteLine("\nÇarpma");
        Console.WriteLine("----------------");

        Console.Write("İlk Sayıyı Giriniz: ");
        string test1 = Console.ReadLine();

        Console.Write("İkinci Sayıyı Giriniz: ");
        string test2 = Console.ReadLine();

        int toplam = Convert.ToInt32(test1) * Convert.ToInt32(test2);

        Console.WriteLine("Sonuç: " + toplam);

        Console.Write("Tekrar işlem yapmak istiyor musunuz? (Y/N): ");
        tekrarla = Console.ReadLine();

        if (tekrarla == "Y")
            Baslat();
        else;
    }
}