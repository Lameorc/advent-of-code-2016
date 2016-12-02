using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code.Day_2
{
    public class KeypadPart2 : Keypad
    {
        private List<int> topRestricted = new List<int>() {1, 2, 4, 5, 9};
        private List<int> bottomRestricted = new List<int>() {5, 9, 10, 12, 13};
        private List<int> leftRestricted = new List<int>() {1,2,5,10,13};
        private List<int> rightRestricted = new List<int>() { 1, 4, 9, 12, 13 };


        public override void Up()
        {
            if (!topRestricted.Contains(Position))
            {
                if (Position >= 2  && Position <= 4)
                {
                    Position = 1;
                }
                else if (Position >=5 && Position <= 12)
                {
                    Position -= 4;
                }
                else if (Position == 13)
                {
                    Position = 11;
                }
            }
        }

        public override void Down()
        {
            if (!bottomRestricted.Contains(Position))
            {
                if (Position == 1)
                {
                    Position = 3;
                }
                else if (Position>=2 && Position<= 9)
                {
                    Position += 4;
                }
                else if (Position == 11)
                {
                    Position = 13;
                }
            }
        }

        public override void Left()
        {
            if (!leftRestricted.Contains(Position))
            {
                Position -= 1;
            }
        }

        public override void Right()
        {
            if (!rightRestricted.Contains(Position))
            {
                Position += 1;
            }
        }
    }
}
