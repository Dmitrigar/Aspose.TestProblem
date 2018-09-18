using System;

namespace T9Spelling
{
    public class T9Message
    {
        public string Latin
        {
            set
            {
                Digital = string.IsNullOrEmpty(value)
                    ? string.Empty
                    : TranslateSingleCharacter(value[0]);
            }
        }
        public string Digital { get; private set; }

        private string TranslateSingleCharacter(char x)
        {
            switch (x)
            {
                case ' ': return "1";
                case 'a': return "2";
                case 'b': return "22";
                case 'c': return "222";
                case 'd': return "3";
                case 'e': return "33";
                case 'f': return "333";
                case 'g': return "4";
                case 'h': return "44";
                case 'i': return "444";
                case 'j': return "5";
                case 'k': return "55";
                case 'l': return "555";
                case 'm': return "6";
                case 'n': return "66";
                case 'o': return "666";
                case 'p': return "7";
                case 'q': return "77";
                case 'r': return "777";
                case 's': return "7777";
                case 't': return "8";
                case 'u': return "88";
                case 'v': return "888";
                case 'w': return "9";
                case 'x': return "99";
                case 'y': return "999";
                case 'z': return "9999";
                case '+': return "0";
                default: return string.Empty;
            }
        }
    }
}
