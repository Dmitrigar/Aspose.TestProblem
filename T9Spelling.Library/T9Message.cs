﻿using System.Linq;
using System.Text;

namespace T9Spelling
{
    public class T9Message
    {
        const char Pause = ' ';

        private string _latin;

        public T9Message(string latin)
        {
            _latin = latin;
        }

        public static implicit operator string(T9Message x)
        {
            return x.ToString();
        }

        public override string ToString()
        {
            return string.IsNullOrEmpty(_latin)
                ? string.Empty
                : TranslateMessage(_latin);
        }

        private string TranslateMessage(string latin)
        {
            return latin
                .Aggregate(new StringBuilder(), AppendSingleCharacterSequence)
                .ToString();
        }

        private StringBuilder AppendSingleCharacterSequence(StringBuilder digital, char ch)
        {
            var sequence = TranslateSingleCharacter(ch);
            AppendPauseIfNecessary(digital, sequence);
            return digital.Append(sequence);
        }

        private void AppendPauseIfNecessary(StringBuilder digital, string sequence)
        {
            if (IsPauseNecessary(digital, sequence))
                digital.Append(Pause);
        }

        private bool IsPauseNecessary(StringBuilder digital, string sequence)
        {
            var len = digital.Length;
            return len > 0 && digital[len - 1] == sequence[0];
        }

        private string TranslateSingleCharacter(char ch)
        {
            switch (ch)
            {
                case ' ': return "0";
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
                default: return string.Empty;
            }
        }
    }
}
