using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Console
{
    public class Rover
    {
        public int x;
        public int y;
        public string dir;
        public Rover(string location)
        {

            x = Convert.ToInt32(location.Split(" ")[0]);
            y = Convert.ToInt32(location.Split(" ")[1]);
            dir = location.Split(" ")[2];

        }
        public void TurnLeft()
        {
            switch (dir)
            {
                case "N":
                    dir = "W";
                    break;
                case "E":
                    dir = "N";
                    break;
                case "S":
                    dir = "E";
                    break;
                case "W":
                    dir = "S";
                    break;
                default:
                    throw new ArgumentException();

            }

        }
        public void TurnRight()
        {
            switch (dir)
            {
                case "N":
                    dir = "E";
                    break;
                case "E":
                    dir = "S";
                    break;
                case "S":
                    dir = "W";
                    break;
                case "W":
                    dir = "N";
                    break;
                default:
                    throw new ArgumentException();
            }

        }
        public void Forward()
        {
            switch (dir)
            {
                case "N":
                    y += 1;
                    break;
                case "E":
                    x += 1;
                    break;
                case "S":
                    y -= 1;
                    break;
                case "W":
                    x -= 1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void Execute(string Command)
        {
            char[] Rotation = Command.ToCharArray();

            for (int i = 0; i < Rotation.Length; i++)
            {
                switch (Rotation[i])
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'M':
                        Forward();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    default:
                        throw new ArgumentException();
                }

            }

        }
    }
}
