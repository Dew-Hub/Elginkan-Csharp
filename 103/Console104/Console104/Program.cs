float islemsonuc;
float sayi1;
float sayi2;
cal();

void cal()
{
    Console.Write("İlk sayıyı giriniz: ");
    sayi1 = Single.Parse(Console.ReadLine());
    Console.Write("İkinci sayıyı giriniz: ");
    sayi2 = Single.Parse(Console.ReadLine());
    Console.WriteLine("-------------------------------------------------------------");

    Console.WriteLine("Toplama (+)");
    Console.WriteLine("Çıkarma (-)");
    Console.WriteLine("Çarpma  (*)");
    Console.WriteLine("Bölme   (/)");

    Console.Write("Operator: ");
    char islem = char.Parse(Console.ReadLine());


    switch (islem)
    {
        case '+':
            Console.WriteLine("İşlem sonucu: "+(sayi1 + sayi2));
            break;

        case '-':
            Console.WriteLine("İşlem sonucu: "+(sayi1 - sayi2));
            break;

        case '*':
            Console.WriteLine("İşlem sonucu: "+(sayi1 * sayi2));
            break;

        case '/':
            Console.WriteLine("İşlem sonucu: "+(sayi1 / sayi2));
            break;

        default:
            Console.WriteLine("İstenilen operator dışında bir girdi girdiniz!");
            Console.WriteLine("-------------------------------------------------------------");
           
            break;
    }
    Console.Read();

}

