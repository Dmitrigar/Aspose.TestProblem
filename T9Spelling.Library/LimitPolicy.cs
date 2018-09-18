using System;
using System.IO;

namespace T9Spelling
{
    public abstract class LimitPolicy : ILimitPolicy
    {
        public virtual int CasesMinNumber => 1;

        public virtual int CasesMaxNumber => 100;

        public virtual int MessageMinLength => 1;

        public abstract int MessageMaxLength { get; }

        public void EnforceCasesNumberLimit(int n)
        {
            if (n < CasesMinNumber)
                throw new InvalidDataException(
                    $"N must not be less than {CasesMinNumber}. Got: {n}.");

            if (n > CasesMaxNumber)
                throw new InvalidDataException(
                    $"N must not be more than {CasesMaxNumber}. Got: {n}.");
        }

        public void EnforceMessageLengthLimit(string message)
        {
            if (message == null)
                throw new ArgumentNullException();

            var len = message.Length;
            if (len < MessageMinLength)
                throw new InvalidDataException(
                    $"Message must not be shorter than {MessageMinLength}. " +
                    $"Got: `{message}` ({len}).");

            if (len > MessageMaxLength)
                throw new InvalidDataException(
                    $"Message must not be longer than {MessageMaxLength}. " +
                    $"Got: `{message}` ({len}).");
        }
    }
}
