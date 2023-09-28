class Program
{
    static void Main(string[] args)
    {

    }
}


class Denemetest
{
    int sayi1 = 10;
    int sayi2 = 5;

    public Denemetest()
    {

        sayi1 = 40;
        sayi2 = 50;
    }
    public Denemetest(int sayi1, int sayi2)
    {
        this.sayi1 = sayi1;
        this.sayi2 = sayi2;
    }
    public void degeral(Denemetest deger)
    {
        deger.sayi1 = 60;
    }
}