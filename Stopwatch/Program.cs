using System.Diagnostics;

Stopwatch sw = new();
C c = new C();


for (int x = 0; x < 10; x++)
{
    sw.Start();
    for (int i = 0; i < 100_000_000; i++)
    {
        int g = c.f;
    }

    sw.Stop();
    Console.WriteLine($"Variable : {sw.ElapsedMilliseconds}");
    sw.Reset();
    sw.Start();

    for (int i = 0; i < 100_000_000; i++)
    {
        int g = c.F;
    }

    sw.Stop();
    Console.WriteLine($"Propriété : {sw.ElapsedMilliseconds}");
    sw.Reset();
}


Console.ReadLine();

public class C
{
    public int f;
    public int F { get; set; }
}