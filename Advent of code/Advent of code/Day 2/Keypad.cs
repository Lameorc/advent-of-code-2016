using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code.Day_2
{
    
    public class Keypad
    {
        public int Position { get; set; }

        private StringBuilder _output;

        public string Output
        {
            get { return _output.ToString(); }
            set { _output = new StringBuilder(value); }
        }

        public Keypad()
        {
            _output = new StringBuilder();
            Position = 5;
        }
        public virtual void Up()
        {
            if (Position > 3)
            {
                Position -= 3;
            }
        }
        public virtual void Down()
        {
            if(Position < 7)
            {
                Position += 3;
            }
        }
        public virtual void Left()
        {
            if (Position != 1 && Position != 4 && Position != 7)
            {
                Position -= 1;
            }
        }

        public virtual void Right()
        {
            if (Position != 3 && Position != 6 && Position != 9)
            {
                Position += 1;
            }
        }
        public virtual void ReadLine(string line)
        {
            foreach (var c in line)
            {
                switch (c)
                {
                    case 'L':
                        Left();
                        break;
                    case 'R':
                        Right();
                        break;
                    case 'U':
                        Up();
                        break;
                    case 'D':
                        Down();
                        break;
                }
            }
            _output.Append(Position.ToString("X"));
        }
    }
}
