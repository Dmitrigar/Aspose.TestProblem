using Xunit;
using T9Spelling.Library;

namespace T9Spelling.Tests
{
    public class T9MessageTest
    {
        [Fact]
        public void EmptyLatinGivesEmptyDigital()
        {
            Assert.Equal(string.Empty, new T9Message()
            {
                Latin = string.Empty
            }.Digital);
        }
    }
}
