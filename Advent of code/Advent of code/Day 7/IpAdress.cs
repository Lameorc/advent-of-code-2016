using System;
using System.Collections.Generic;

namespace Advent_of_code.Day_7
{
    public class IpAdress
    {
        public string Address { get; set; }

        public IpAdress(string address)
        {
            Address = address;
        }

        public bool IsTlsCapable()
        {
            var sequenceFoundOutsideOfBrackets = false;
            var inBrackets = false;
            for (int i = 0; i < Address.Length-3; i++)
            {
                if (Address[i] == '[')
                {
                    inBrackets = true;
                    continue;
                }
                if (Address[i] == ']')
                {
                    inBrackets = false;
                    continue;
                }
                char first = Address[i];
                char second = Address[i + 1];
                if (first == second)
                {
                    continue;
                }
                char third = Address[i + 2];
                if (third != second)
                {
                    continue;
                }
                char fourth = Address[i + 3];
                if (fourth == first)
                {
                    if (inBrackets)
                    {
                        return false;
                    }
                    sequenceFoundOutsideOfBrackets = true;
                }
            }
            return sequenceFoundOutsideOfBrackets;
        }

        public bool IsSslCapable()
        {
            var inBrackets = false;
            List<string> wordsIn = new List<string>();
            List<string> wordsOut = new List<string>();

            for (int i = 0; i < Address.Length - 2; i++)
            {
                if (Address[i] == '[')
                {
                    inBrackets = true;
                    continue;
                }
                if (Address[i] == ']')
                {
                    inBrackets = false;
                    continue;
                }
                char first = Address[i], second = Address[i + 1], third = Address[i + 2];
                if (inBrackets)
                {
                    if (first == third && first != second)
                    {
                        wordsIn.Add($"{first}{second}{third}");
                    }
                }
                else
                {
                    if (first == third && first != second)
                    {
                        wordsOut.Add($"{first}{second}{third}");
                    }
                }
            }
            foreach (var word in wordsIn)
            {
                string swapped = $"{word[1]}{word[0]}{word[1]}";
                if (wordsOut.Contains(swapped))
                {
                    return true;
                }
            }
            return false;
        }
    }
}