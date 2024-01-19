namespace PerformanceDemo.BenchMarker
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Mathematics;
    using BenchmarkDotNet.Order;

    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class StringComparisonWithCase
    {
        string strA = "Sudhakar";
        string strB = "Sudhakar";

        [Benchmark()]
        public void EqualityComparisonwithCase()
        {
            var sc = new StringComparisonOperation().EqualityComparisonWithCase(strA, strB);
        }

        [Benchmark()]
        public void EqualsComparisonWithCase()
        {
            var sc = new StringComparisonOperation().EqualsComparisonWithCase(strA, strB);
        }

        [Benchmark()]
        public void StringCompareComparisonWithCase()
        {
            var sc = new StringComparisonOperation().StringCompareComparisonWithCase(strA, strB);
        }
    }
}
