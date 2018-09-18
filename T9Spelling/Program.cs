using System;
using System.Linq;
using System.IO;

namespace T9Spelling
{
    public class Program
    {
        static void Main(string[] args)
        {
            var limitPolicy = GetLimitPolicy(args);
            var casesNumber = ReadCasesNumber(limitPolicy);
            for (int position = 1; position <= casesNumber; ++position)
            {
                var latin = ReadMessage(position, limitPolicy);
                var digital = new T9Message(latin);
                Console.WriteLine($"Case #{position}: {digital}");
            }
        }

        static ILimitPolicy GetLimitPolicy(string[] args)
        {
            return args != null && args.Any() && args.First() == "--small"
                ? (ILimitPolicy)new SmallModeLimitPolicy()
                : new LargeModeLimitPolicy();
        }

        static int ReadCasesNumber(ILimitPolicy limitPolicy)
        {
            var firstLine = Console.ReadLine();
            if (!int.TryParse(firstLine, out int n))
                throw new InvalidDataException(
                    $"First line must be a number. Got: `{firstLine}`.");

            limitPolicy.EnforceCasesNumberLimit(n);
            return n;
        }

        static string ReadMessage(int position, ILimitPolicy limitPolicy)
        {
            var message = Console.ReadLine();
            if (message == null)
                throw new InvalidDataException(
                    $"Expected message at position {position}. Got null.");

            limitPolicy.EnforceMessageLengthLimit(message);
            return message;
        }
    }
}
