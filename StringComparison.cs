namespace PerformanceDemo.BenchMarker
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Mathematics;
    using BenchmarkDotNet.Order;

    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class StringComparison
    {
        string strA = "Sudhakar";
        string strB = "Sudhakar";

        [Benchmark()]
        public void EqualityComparison()
        {
            var sc = new StringComparisonOperation().EqualityComparison(strA,strB);
        }

        [Benchmark()]
        public void EqualsComparison()
        {
            var sc = new StringComparisonOperation().EqualsComparison(strA, strB);
        }

        [Benchmark()]
        public void StringCompareComparison()
        {
            var sc = new StringComparisonOperation().StringCompareComparison(strA, strB);
        }


    }
}
