namespace T9Spelling
{
    public class LargeModeLimitPolicy : LimitPolicy
    {
        public override int MessageMaxLength => 1000;
    }
}
