using System;

namespace T9Spelling
{
    public class T9Message
    {
        public string Latin
        {
            set
            {
                Digital = string.Empty;
            }
        }
        public string Digital { get; private set; }

    }
}
