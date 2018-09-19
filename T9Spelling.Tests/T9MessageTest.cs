using Xunit;

namespace T9Spelling
{
    public class T9MessageTest
    {
        [Fact]
        public void EmptyLatinGivesEmptyDigital()
        {
            Assert.Equal(string.Empty, new T9Message(string.Empty));
        }

        [Fact]
        public void SingleCharacterGivesRightSequence()
        {
            Assert.Equal("0", new T9Message(" "));
            Assert.Equal("2", new T9Message("a"));
            Assert.Equal("22", new T9Message("b"));
            Assert.Equal("222", new T9Message("c"));
            Assert.Equal("3", new T9Message("d"));
            Assert.Equal("33", new T9Message("e"));
            Assert.Equal("333", new T9Message("f"));
            Assert.Equal("4", new T9Message("g"));
            Assert.Equal("44", new T9Message("h"));
            Assert.Equal("444", new T9Message("i"));
            Assert.Equal("5", new T9Message("j"));
            Assert.Equal("55", new T9Message("k"));
            Assert.Equal("555", new T9Message("l"));
            Assert.Equal("6", new T9Message("m"));
            Assert.Equal("66", new T9Message("n"));
            Assert.Equal("666", new T9Message("o"));
            Assert.Equal("7", new T9Message("p"));
            Assert.Equal("77", new T9Message("q"));
            Assert.Equal("777", new T9Message("r"));
            Assert.Equal("7777", new T9Message("s"));
            Assert.Equal("8", new T9Message("t"));
            Assert.Equal("88", new T9Message("u"));
            Assert.Equal("888", new T9Message("v"));
            Assert.Equal("9", new T9Message("w"));
            Assert.Equal("99", new T9Message("x"));
            Assert.Equal("999", new T9Message("y"));
            Assert.Equal("9999", new T9Message("z"));
        }

        [Fact]
        public void DifferentDigitCharactersGivesRightSequence()
        {
            Assert.Equal("299", new T9Message("ax"));
            Assert.Equal("233399", new T9Message("afx"));
            Assert.Equal("299044477770299", new T9Message("ax is ax"));
        }

        [Fact]
        public void SameDigitCharactersTogetherGivesPauseBetween()
        {
            Assert.Equal("2 2", new T9Message("aa"));
            Assert.Equal("2 22 2223 33 3334", new T9Message("abcdefg"));
            Assert.Equal("2 2202223033 33304 44", new T9Message("ab cd ef gh"));
        }
    }
}
