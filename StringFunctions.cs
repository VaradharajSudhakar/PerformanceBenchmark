using BenchmarkDotNet.Attributes;

namespace PerformanceDemo.BenchMarker
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Mathematics;
    using BenchmarkDotNet.Order;

    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class StringFunctions
    {
        //[Benchmark]
        //public void BuildStringBadly()
        //{
        //    var x = new StringOperation().BuildStringBadly("Test");
        //}

        //[Benchmark]
        //public void BuildStringBetter()
        //{
        //    var x = new StringOperation().BuildStringBetter("Test");
        //}


        [Benchmark]
        public void NaiveSplit()
        {
            var x = new StringOperation().NavieSplitName("Varadharaj, Sudhakar");
        }

        [Benchmark]
        public void SplitSplit()
        {
            var x = new StringOperation().SplitSplitName("Varadharaj, Sudhakar");
        }

        [Benchmark]
        public void SpanSplit()
        {
            var x = new StringOperation().SpanSplitName("Varadharaj, Sudhakar");
        }
    }
}

