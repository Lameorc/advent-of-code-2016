using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code.Day_3
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
            var possible = 0;
            using (
                var reader =
                    new System.IO.StreamReader(
                        "E:\\Data\\coding\\Various\\Advent of code 2016\\Advent of code\\Advent of code\\Day 3\\input.txt")
            )
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var sides = Array.ConvertAll(line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries), int.Parse);
                    possible += sides[0] < sides[1] + sides[2] ?
                        (sides[1] < sides[0] + sides[2] ? 
                        (sides[2] < sides[0] + sides[1] ? 1 : 0)
                        : 0)
                        : 0;
                }
            }
            System.Console.WriteLine(possible);
        }

        public void Part2()
        {
            var possible = 0;
            using (
                var reader =
                    new System.IO.StreamReader(
                        "E:\\Data\\coding\\Various\\Advent of code 2016\\Advent of code\\Advent of code\\Day 3\\input.txt")
            )
            {
                string line1, line2, line3;
                while ((line1 = reader.ReadLine()) != null && (line2 = reader.ReadLine()) != null && (line3 = reader.ReadLine())!= null )
                {
                    var sides1 = Array.ConvertAll(line1.Split(new char[0], StringSplitOptions.RemoveEmptyEntries), int.Parse);
                    var sides2 = Array.ConvertAll(line2.Split(new char[0], StringSplitOptions.RemoveEmptyEntries), int.Parse);
                    var sides3 = Array.ConvertAll(line3.Split(new char[0], StringSplitOptions.RemoveEmptyEntries), int.Parse);
                    possible += sides1[0] < sides2[0] + sides3[0] ?
                        (sides2[0] < sides1[0] + sides3[0] ?
                        (sides3[0] < sides1[0] + sides2[0] ? 1 : 0)
                        : 0)
                        : 0;
                    possible += sides1[1] < sides2[1] + sides3[1] ?
                        (sides2[1] < sides1[1] + sides3[1] ?
                        (sides3[1] < sides1[1] + sides2[1] ? 1 : 0)
                        : 0)
                        : 0;
                    possible += sides1[2] < sides2[2] + sides3[2] ?
                        (sides2[2] < sides1[2] + sides3[2] ?
                        (sides3[2] < sides1[2] + sides2[2] ? 1 : 0)
                        : 0)
                        : 0;
                }
                System.Console.WriteLine(possible);
            }
        }

    }
}
