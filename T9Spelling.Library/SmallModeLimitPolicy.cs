namespace T9Spelling
{
    public class SmallModeLimitPolicy : LimitPolicy
    {
        public override int MessageMaxLength => 15;
    }
}
