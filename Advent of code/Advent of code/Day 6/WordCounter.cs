using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Advent_of_code.Day_6
{
    public class WordCounter
    {
        public List<string> Words { get; set; }
        public List<char>[] Characters { get; set; }
        public WordCounter()
        {
            Words = new List<string>();
            Characters = new List<char>[8];
            for (int index = 0; index < Characters.Length; index++)
            {
                Characters[index] = new List<char>();
            }
        }

        public void ReadWords(string filename)
        {
            using (var fr = new StreamReader(filename))
            {
                string line;
                while ((line = fr.ReadLine()) != null)
                {
                    Words.Add(line);
                }
            }
        }

        public string GetRealMessagePart1()
        {
            
            string realMessage = "";
            ExtractCharactersToList();
            for (int i = 0; i < Words.First().Length; i++)
            {
                var list = Characters[i];
                realMessage += list.GroupBy(c => c).OrderByDescending(c => c.Count()).First().Key;
            }
            return realMessage;
        }

        public string GetRealMessagePart2()
        {
            string realMessage = "";
            ExtractCharactersToList();
            for (int i = 0; i < Words.First().Length; i++)
            {
                var list = Characters[i];
                realMessage += list.GroupBy(c => c).OrderBy(c => c.Count()).First().Key;
            }
            return realMessage;
        }

        private void ExtractCharactersToList()
        {
            foreach (var word in Words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    Characters[i].Add(word[i]);
                }
            }
        }
    }
}