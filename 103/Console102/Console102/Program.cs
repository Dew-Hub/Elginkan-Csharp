swcase();
void swcase()
{
	Console.Write("1 ile 4 arasında sayı giriniz: ");
	byte a = byte.Parse(Console.ReadLine());
	switch (a)
	{
		case 1:
			Console.WriteLine("BİR");
			break;
		case 2:
            Console.WriteLine("İKİ");
            break;
		case 3:
            Console.WriteLine("ÜÇ");
            break;
		case 4:
            Console.WriteLine("DÖRT");
            break;
		default:
			Console.WriteLine("İstenen değerin dışında bir girdi girildi");
            Console.WriteLine("------------------------------------------------");
            swcase();
			break;
	}
    Console.Read();

}