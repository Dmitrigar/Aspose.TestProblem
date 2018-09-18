using System.Collections.Generic;
using System.Linq;
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
            new Dictionary<string, string>()
            {
                { " ", "1"   },
                { "a", "2"   },
                { "b", "22"  },
                { "c", "222" },
                { "d", "3"   },
                { "e", "33"  },
                { "f", "333" },
                { "g", "4"   },
                { "h", "44"  },
                { "i", "444" },
                { "j", "5"   },
                { "k", "55"  },
                { "l", "555" },
                { "m", "6"   },
                { "n", "66"  },
                { "o", "666" },
                { "p", "7"   },
                { "q", "77"  },
                { "r", "777" },
                { "s", "7777"},
                { "t", "8"   },
                { "u", "88"  },
                { "v", "888" },
                { "w", "9"   },
                { "x", "99"  },
                { "y", "999" },
                { "z", "9999"},
                { "+", "0"   },
            }
            .ToList()
            .ForEach(x => Assert.Equal(x.Value, new T9Message(x.Key)));
        }

        [Fact]
        public void DifferentDigitCharactersGivesRightSequence()
        {
            new Dictionary<string, string>()
            {
                { "ax", "299" },
                { "a+x", "2099" },
                { "a+x is ax", "2099144477771299" },
            }
            .ToList()
            .ForEach(x => Assert.Equal(x.Value, new T9Message(x.Key)));
        }
    }
}
