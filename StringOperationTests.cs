namespace PerformanceDemo.StringOpertaion.Tests
{
    using Xunit;
    public class StringOperationTests
    {
        string expectedString = "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test";
        [Fact]
        public void BuildStringBadly()
        {
            
            var s = new StringOperation().BuildStringBadly("Test");
            Assert.Equal(expectedString, s);
        }

        [Fact]
        public void BuildStringBetter()
        {
            var s = new StringOperation().BuildStringBetter("Test");
            Assert.Equal(expectedString, s);
        }

        [Fact]
        public void FunctionAreEquivalent()
        {
            var sb = new StringOperation();

            var sbad = sb.BuildStringBadly("Test");

            var sbetter = sb.BuildStringBetter("Test");

            Assert.Equal(sbetter, sbad);
        }

        [Fact]
        public void NavieSplitName()
        {
            var name = "Varadharaj, Sudhakar";
            var sb = new StringOperation();

            var lName = sb.NavieSplitName(name).LastName;
            var fName = sb.NavieSplitName(name).FirstName;

            Assert.Equal("Varadharaj", lName);
            Assert.Equal("Sudhakar", fName);
           
        }


        [Fact]
        public void SplitSplitName()
        {
            var name = "Varadharaj, Sudhakar";
            var sb = new StringOperation();

            var lName = sb.SplitSplitName(name).LastName;
            var fName = sb.SplitSplitName(name).FirstName;

            Assert.Equal("Varadharaj", lName);
            Assert.Equal("Sudhakar", fName);

        }


        [Fact]
        public void SpanSplitName()
        {
            var name = "Varadharaj, Sudhakar";
            var sb = new StringOperation();

            var lName = sb.SpanSplitName(name).LastName;
            var fName = sb.SpanSplitName(name).FirstName;

            Assert.Equal("Varadharaj", lName);
            Assert.Equal("Sudhakar", fName);

        }
    }
}