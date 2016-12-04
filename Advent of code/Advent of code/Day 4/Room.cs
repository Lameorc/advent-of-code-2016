using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Advent_of_code.Day_4
{
    public class Room
    {

        public string Checksum { get; }
        public string Name { get; }
        public int Number { get; }

        public Room(string inputLine)
        {
            Regex re = new Regex(@"(?<name>[\D*-]*)-(?<number>\d*)\[(?<checksum>\S*)\]");
            var match = re.Match(inputLine);
            Checksum = match.Groups["checksum"].Value;
            Name = match.Groups["name"].Value;
            Number = int.Parse(match.Groups["number"].Value);
        }

        public bool IsReal()
        {
            var dict = new SortedDictionary<char, int>(Name.GroupBy(c => c) // put each character into a "bucket"
                .ToDictionary(c => c.Key, c => c.Count()));
            dict.Remove('-');
            var sortedByValue = dict.OrderByDescending(d => d.Value);
            var letters = sortedByValue.ToDictionary(s => s.Key, s=> s.Value).Keys.ToList();
            for (int i = 0; i < 5; i++)
            {
                if (letters[i] != Checksum[i])
                {
                    return false;
                } 
            }
            return true;
        }

        public string DecryptName()
        {
            var decryptedName = Name.Replace('-', ' ').ToLowerInvariant().ToCharArray(); 
            for (int i = 0; i < Number; i++)
            {
                for (int j = 0; j < decryptedName.Length; j++)
                {
                    if (Name[j] == '-')
                    {
                        continue;
                    }
                    if (decryptedName[j] == 'z')
                    {
                        decryptedName[j] = 'a';
                    }
                    else
                    {
                        decryptedName[j] = ++decryptedName[j];
                    }
                }
            }
            return new string(decryptedName);
        }
    }
}
