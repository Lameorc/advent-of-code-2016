using System;
using System.Linq;

namespace Advent_of_code.Day_5
{
    public class Runner
    {
        private static string ValidPositions { get; } = "01234567";

        public void Run()
        {
            Part1();
        }

        private static void Part1()
        {
            var hasher = new Hasher("wtnhxymk", 0);
            hasher.ComputeNextHash();
            var password = "zzzzzzzz".ToCharArray();
            
            while (new string(password).Contains("z"))
            {
                var hash = hasher.Hash;
                if (hash.StartsWith("00000"))
                {
                    if (ValidPositions.Contains(hash[5]) )
                    {
                        var pos = int.Parse(hash[5].ToString());
                        if (password[pos] == 'z')
                        {
                            password[pos] = hash[6];
                        }
                    }
                }
                hasher.ComputeNextHash();
            }
            System.Console.WriteLine($"Day 5, part 2: {new string(password)}");
        }
    }
}