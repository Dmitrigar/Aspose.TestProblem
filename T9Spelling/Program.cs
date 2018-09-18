using System;

namespace T9Spelling
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (!IsValidArgs(args))
            {
                Console.WriteLine("* The T9Spelling program *");
                Console.WriteLine("    This program translates latin character message to T9 digital button keypress sequence.");
                Console.WriteLine();
                Console.WriteLine("Usage:");
                Console.WriteLine("    t9spelling.exe <input-file-path> [--small-input|--large-input]");
                Console.WriteLine();
            }
        }

        public static bool IsValidArgs(string[] args)
        {
            if (args == null)
                return false;
            
            if (args.Length < 1)
                return false;

            return true;
        }
    }
}
