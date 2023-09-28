Test t = new Test();
t.A = 9;
Console.WriteLine(t.B);
Console.WriteLine(t.A);



class Test
{
    public int C { get; set; }
    int a;
    int b = 5;
    public int A
    {
        get { return a; }
        set { a = value; }
    }
    public int B
    { 
        get
        {
            return b;
        }
    }
}

