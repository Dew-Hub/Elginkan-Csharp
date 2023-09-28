class Program
{
    static void Main(string[] args)
    {
        C cey = new C(2,4,6,8,10,12);
        cey.Yazdir();
        Console.Read();
    }
}

class A
{
    public int a;
    public int b;
    public A(int a, int b)
    {
        this.a = a;
        this.b = b;

        Console.WriteLine("Temel sınıf kurucu metodu çalıştı...");
    }
}

class B : A
{
    public int c;
    public int d;
    public B(int a, int b,int c,int d):base(a,b)
    {
        this.c = c;
        this.d = d;
        
        Console.WriteLine("Türetilmiş sınıfın kurucu metodu çalıştı...");
    }


}

class C : B
{
    public int k;
    public int l;

    public C(int a, int b, int c, int d, int k, int l):base(a,b,c,d)
    {
        this.k = k;
        this.l = l;


    }
    public void Yazdir()
    {
        Console.Write("{0},{1},{2},{3},{4},{5}", a, b, c, d, k, l);
    }
}