using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;

internal class Program
{
    private static void Main(string[] args)
    {
        BenchmarkRunner.Run<StringComparisonBenchmark>();
    }
}

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class StringComparisonBenchmark
{
    private const int StringLength = 1000;

    private string _longString;
    private string _longString1;

    [GlobalSetup]
    public void Setup()
    {
        _longString = new string('a', StringLength);
        _longString1 = new string('A', StringLength);
    }
    [Benchmark]
    public bool CompareUsingEqualsOrdinalIgnoreCase()
    {
        return string.Equals(_longString, _longString, StringComparison.OrdinalIgnoreCase);
    }
    [Benchmark]
    public bool CompareUsingEqualsInvariantCultureIgnoreCase()
    {
        return string.Equals(_longString, _longString, StringComparison.InvariantCultureIgnoreCase);
    }

    [Benchmark]
    public int CompareUsingCompareTo()
    {
        return string.Compare(_longString, _longString, true);
    }

    [Benchmark]
    public bool CompareUsingEqualityOperatorToLower()
    {
        return _longString.ToLower() == _longString.ToLower(); ;
    }
    [Benchmark]
    public bool CompareUsingEqualityOperatorToUpper()
    {
        return _longString.ToUpper() == _longString.ToUpper(); ;
    }

    [Benchmark]
    public bool CompareUsingCustomMethod()
    {
        return _longString.Length == _longString.Length && _longString.All(c => _longString.Contains(c));
    }
}