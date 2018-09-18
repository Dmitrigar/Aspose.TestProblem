namespace T9Spelling
{
    public interface ILimitPolicy
    {
        int CasesMinNumber { get; }

        int CasesMaxNumber { get; }

        int MessageMinLength { get; }

        int MessageMaxLength { get; }

        void EnforceCasesNumberLimit(int n);

        void EnforceMessageLengthLimit(string message);
    }
}
