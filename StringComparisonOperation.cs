namespace PerformanceDemo
{
    public class StringComparisonOperation
    {
        public bool EqualityComparison(string s1, string s2)
        {
            var results = s1 == s2;

            return results;
        }

        public bool EqualsComparison(string s1, string s2)
        {
            var results = s1.Equals(s2);

            return results;
        }

        public int StringCompareComparison(string s1, string s2)
        {
            var results = string.Compare(s1, s2);

            return results;
        }


        public bool EqualityComparisonWithCase(string s1, string s2)
        {
            var results = s1.ToUpper() == s2.ToUpper();

            return results;
        }

        public bool EqualsComparisonWithCase(string s1, string s2)
        {
            var results = s1.ToUpper().Equals(s2.ToUpper());

            return results;
        }

        public int StringCompareComparisonWithCase(string s1, string s2)
        {
            var results = string.Compare(s1, s2,true);

            return results;
        }
    }
}
