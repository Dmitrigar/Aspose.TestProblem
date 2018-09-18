using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace T9Spelling
{
    public class LimitPolicyTest
    {
        private readonly List<ILimitPolicy> policies = new List<ILimitPolicy>()
        {
            new SmallModeLimitPolicy(),
            new LargeModeLimitPolicy(),
        };

        [Fact]
        public void TooLittleCasesTrowsInvalidDataException()
        {
            policies.ForEach(policy => 
                Assert.Throws<InvalidDataException>(() =>
                    policy.EnforceCasesNumberLimit(policy.CasesMinNumber - 1)));
        }

        [Fact]
        public void AllowedNumberOfCasesPass()
        {
            policies.ForEach(policy =>
                Enumerable
                    .Range(policy.CasesMinNumber, policy.CasesMaxNumber)
                    .ToList()
                    .ForEach(x => policy.EnforceCasesNumberLimit(x)));
        }

        [Fact]
        public void TooMuchCasesTrowsInvalidDataException()
        {
            policies.ForEach(policy => 
                Assert.Throws<InvalidDataException>(() =>
                    policy.EnforceCasesNumberLimit(policy.CasesMaxNumber + 1)));
        }

        [Fact]
        public void NullMessageThrowsArgumentNullException()
        {
            policies.ForEach(policy => 
                Assert.Throws<ArgumentNullException>(() =>
                    policy.EnforceMessageLengthLimit(null)));
        }

        [Fact]
        public void TooShortMessageThrowsInvalidDataException()
        {
            policies.ForEach(policy =>
                Assert.Throws<InvalidDataException>(() =>
                    policy.EnforceMessageLengthLimit(
                        new string('a', policy.MessageMinLength - 1))));
        }

        [Fact]
        public void AllowedMessageLengthPsss()
        {
            policies.ForEach(policy => 
                Enumerable
                    .Range(policy.MessageMinLength, policy.MessageMaxLength)
                    .Select(x => new string('a', x))
                    .ToList()
                    .ForEach(x => policy.EnforceMessageLengthLimit(x)));
        }

        [Fact]
        public void TooLongMessageThrowsInvalidDataException()
        {
            policies.ForEach(policy => 
                Assert.Throws<InvalidDataException>(() =>
                    policy.EnforceMessageLengthLimit(
                        new string('a', policy.MessageMaxLength + 1))));
        }
    }
}
