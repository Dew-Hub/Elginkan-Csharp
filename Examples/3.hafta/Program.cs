int a;
int b;


Console.Write("a sayısını giriniz:");
a = int.Parse(Console.ReadLine());

Console.Write("b sayısını giriniz:");
b = int.Parse(Console.ReadLine());

Console.WriteLine();

if (a > b)
    Console.WriteLine("a(" + a + ") sayısı b(" + b + ") sayısından büyüktür");
else
    Console.WriteLine("a(" + a + ") sayısı b(" + b + ") sayısından küçüktür");

Console.ReadLine();