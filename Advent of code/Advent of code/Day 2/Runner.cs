using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code.Day_2
{
    public class Runner
    {

        public void Run()
        {
            var keypad = new KeypadPart2();
            var file = new System.IO.StreamReader("e:/Data/coding/Various/Advent of code 2016/Day 2/input.txt");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                keypad.ReadLine(line);
            }
            System.Console.WriteLine(keypad.Output);
        }
    }
}
