using System;
using System.Collections.Generic;
using System.IO;

namespace Advent_of_code.Day_7
{
    public class Runner
    {
        public void Run()
        {
            Part1();
            Part2();
        }

        private void Part1()
        {
            int valid = 0;
            using (var fr = new StreamReader(@"E:\Data\coding\Various\Advent of code 2016\Advent of code\Advent of code\Day 7\input.txt"))
            {
                string line;
                var address = new IpAdress("");
                while ((line = fr.ReadLine()) != null )
                {
                    address.Address = line;
                    valid += address.IsTlsCapable() ? 1 : 0;
                }
            }
            Console.WriteLine($"Day 7, part 1: {valid}");
        }

        private void Part2()
        {
            int valid = 0;
            using (var fr = new StreamReader(@"E:\Data\coding\Various\Advent of code 2016\Advent of code\Advent of code\Day 7\input.txt"))
            {
                string line;
                var address = new IpAdress("");
                while ((line = fr.ReadLine()) != null)
                {
                    address.Address = line;
                    valid += address.IsSslCapable() ? 1 : 0;
                }
            }
            Console.WriteLine($"Day 7, part 2: {valid}");
        }
    }
}