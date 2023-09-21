swcase();
void swcase()
{
    Console.Write("Bir ay giriniz: ");
    string a = Console.ReadLine().ToUpper();
    switch (a)
    {
        case "ARALIK":
        case "OCAK":
        case "ŞUBAT":
            Console.WriteLine("Kış");
            break;
        
        case "MART":
        case "NİSAN":
        case "MAYIS":
            Console.WriteLine("İlkbahar");
            break;
        
        case "HAZİRAN":
        case "TEMMUZ":
        case "AĞUSTOS":
            Console.WriteLine("Yaz");
            break;
        
        case "EYLÜL":
        case "EKİM":
        case "KASIM":
            Console.WriteLine("Sonbahar");
            break;

        default:
            Console.WriteLine("Sadece ay girdisi yapınız.");
            Console.WriteLine("------------------------------------------------");
            swcase();
            break;
    }
    Console.Read();

}
