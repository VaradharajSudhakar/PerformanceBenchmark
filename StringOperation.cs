namespace PerformanceDemo
{
    using System.Text;
    public class StringOperation
    {
        public string BuildStringBadly(string message)
        {
            for (int i = 0; i < 50; i++) {
                message += " "  + "Test";
            }
            return message;
        }

        public string BuildStringBetter(string message)
        {
            var stringBuild = new StringBuilder(message);

            for(int i = 0;i < 50;i++)
            {
                stringBuild.Append(" ");
                stringBuild.Append("Test");
            }
            return stringBuild.ToString();
        }


        public (string LastName,string FirstName) NavieSplitName(string givenName)
        {
            var commaPosition = givenName.IndexOf(',');

            var LastName = givenName.Substring(0, commaPosition);
            var FirstName = givenName.Substring(commaPosition+ 2);

            return (LastName, FirstName);

        }


        public (string LastName, string FirstName) SplitSplitName(string givenName)
        {
            var nameArray = givenName.Split(',');

            return (nameArray[0].Trim(), nameArray[1].Trim());

        }


        public (string LastName, string FirstName) SpanSplitName(string givenName)
        {
            ReadOnlySpan<char> nameSpan = givenName.AsSpan();

            var LastName = nameSpan.Slice(0, givenName.IndexOf(',')).ToString();
            var FirstName = nameSpan.Slice(givenName.IndexOf(',') + 2).ToString();

            return (LastName, FirstName);

        }
    }
}
