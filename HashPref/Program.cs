using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace HashPref;

public class Program
{
    private float M1, M2, M3, M4, M5, M6, M7, M8, M9, M10, M11, M12, M13, M14, M15, M16;
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<Program>();
    }

    [Benchmark]
    public int HashcodeAdd()
    {
        HashCode hs = new HashCode();

        hs.Add(M1);
        hs.Add(M2);
        hs.Add(M3);
        hs.Add(M4);
        hs.Add(M5);
        hs.Add(M6);
        hs.Add(M7);
        hs.Add(M8);
        hs.Add(M9);
        hs.Add(M10);
        hs.Add(M11);
        hs.Add(M12);
        hs.Add(M13);
        hs.Add(M14);
        hs.Add(M15);
        hs.Add(M16);

        return hs.ToHashCode();
    }

    [Benchmark]
    public int HashCodeCombine()
    {
        int h1 = HashCode.Combine(M1, M2, M3, M4, M5, M6, M7, M8);
        int h2 = HashCode.Combine(M9, M10, M11, M12, M13, M14, M15, M16);
        return HashCode.Combine(h1, h2);
    }
}
