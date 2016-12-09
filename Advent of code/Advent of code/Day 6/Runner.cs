namespace Advent_of_code.Day_6
{
    public class Runner
    {
        public void Run()
        {
            Part1();
            Part2();
        }


        public void Part1()
        {
            var wc = new WordCounter();
            wc.ReadWords(@"E:\Data\coding\Various\Advent of code 2016\Advent of code\Advent of code\Day 6\input.txt");
            System.Console.WriteLine($"Day 6, part 1: {wc.GetRealMessagePart1()}");
        }
        public void Part2()
        {
            var wc = new WordCounter();
            wc.ReadWords(@"E:\Data\coding\Various\Advent of code 2016\Advent of code\Advent of code\Day 6\input.txt");
            System.Console.WriteLine($"Day 6, part 2: {wc.GetRealMessagePart2()}");
        }
    }
   
}