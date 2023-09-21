//switch case içerisinde switch case kullanmak.
//mantığı açıklamak için yazıldı tam bir program değil!

byte boyut;
byte sekil;
dongu();

void dongu()
{
    Console.Write("Hesaplanmasını istediğiniz şeklin boyutu? (2/3): ");
    boyut = byte.Parse(Console.ReadLine());


    switch (boyut)
    {
        case 2:
            Console.Write("Şekil: ");
            sekil = byte.Parse(Console.ReadLine());
            switch (sekil)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;

                default: break;
            }
            break;

        case 3:
            Console.Write("Şekil: ");
            sekil = byte.Parse(Console.ReadLine());
            switch (sekil)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;

                default: break;
            }
            break;

        default:
            Console.WriteLine("Şeklinize göre düzgün bir boyut girdisi giriniz.");
            Console.WriteLine("-------------------------------------------------------------");

            break;
    }
    Console.Read();

}


