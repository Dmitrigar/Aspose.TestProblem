using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace T9Spelling
{
    public class ProgramTest
    {
        [Fact]
        public void NullArgsConsideredInvalid()
        {
            Assert.False(Program.IsValidArgs(null));
        }
    }
}
