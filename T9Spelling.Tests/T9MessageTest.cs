using Xunit;

namespace T9Spelling
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
