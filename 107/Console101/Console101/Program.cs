class Program
{
    static void Main()
    {
        Deneme1 dn = new Deneme1(1,2);
        dn.x = 3;
        dn.y = 4;
        dn.A();
    }

}

class Deneme
{
    protected int _x, _y;
    public int x { get {return _x;} set {_x = value;} }
    public int y { get { return _y; } set { _y = value; } }

    protected int Topla()
    {
        int topla = _x + _y;
        return topla;
    }

}

class Deneme1:Deneme
{


    public Deneme1(int a, int b)
    {

    }
    public int A()
    {
        return _x + _y;
    }

    public void Invoke()
    {
        Topla();
    }
}

class Deneme2 : Deneme1
{
    public Deneme2(int a, int b) : base(5, 6)
    {
    }
}