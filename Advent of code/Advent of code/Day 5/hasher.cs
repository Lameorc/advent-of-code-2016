using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Advent_of_code.Day_5
{
    public class Hasher
    {
        private readonly string _base;
        private int _currentValue;
        private readonly MD5 _md5;
        public string Hash { get; set; }

        public Hasher(string @base, int currentValue)
        {
            _md5 = new MD5Cng();
            _base = @base;
            _currentValue = currentValue;
        }

        public void ComputeNextHash()
        {
            var output = new StringBuilder();
            using (var stream = new MemoryStream())
            {
                var writer = new StreamWriter(stream);
                writer.Write(_base + _currentValue);
                writer.Flush();
                stream.Position = 0;
                var hash = _md5.ComputeHash(stream);
                for (int i = 0; i < hash.Length; i++)
                {
                    output.Append($"{hash[i]:X2}");
                }
            }
            ++_currentValue;
            Hash = output.ToString();
        }

    }
}