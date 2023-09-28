class Program
{
    static void Main(string[] args)


    { 

    }
}

class MyClass
{
    public int deger;
    public int deger2;
    public int yas;
    public string isim;

    public MyClass()
    {
        deger = 5;
    }
    public MyClass(int parametre)
    { 
        deger = parametre;
    }
    public MyClass(int parametre, int parametre2)
    {
        deger = parametre2;
    }
    public MyClass(string isim)
    { 
        this.isim = isim;
    }

    public MyClass(string isim, int yas)
    {
        this.isim = isim;
        this.yas = yas;
    }

}
