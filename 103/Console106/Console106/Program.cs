
int t = 0;
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("For: "+i);
}


do
{
    Console.WriteLine("Do While: "+t);
    t++;
} while (t < 6);

t = 0;

while (t < 6)
{

    Console.WriteLine("While: " + t);
    t++;
}



Console.WriteLine("---------------------------\nBreak mantığı");
t = 0;

while (true)
{
    if (t > 10) break; 

    Console.WriteLine(t);
    
    t++;
}