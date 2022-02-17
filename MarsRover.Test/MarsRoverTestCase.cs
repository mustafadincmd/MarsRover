using MarsRover.Console;
using Xunit;

namespace MarsRover.Test
{
    public class MarsRoverTestCase
    {
        [Fact]
        public void TurnLeft()
        {
            Rover rover = new Rover("1 2 W");
            rover.TurnLeft();
            Assert.Equal("S",rover.dir);
        }
        [Fact]
        public void TurnRight()
        {
            Rover rover = new Rover("1 2 N");
            rover.TurnRight();
            Assert.Equal("E", rover.dir);

        }
        [Fact]
        public void ForwardS()
        {
            Rover rover = new Rover("1 3 S");
            rover.Forward();
            Assert.Equal(2, rover.y);

        }
        [Fact]
        public void ForwardN()
        {
            Rover rover = new Rover("1 3 N");
            rover.Forward();
            Assert.Equal(4, rover.y);

        }
        [Fact]
        public void ForwardE()
        {
            Rover rover = new Rover("0 0 E");
            rover.Forward();
            Assert.Equal(1, rover.x);

        }
        [Fact]
        public void ForwardW()
        {
            Rover rover = new Rover("1 0 W");
            rover.Forward();
            Assert.Equal(0, rover.x);

        }
        [Fact]
        public void TestInput1()
        {
            Rover rover = new Rover("1 2 N");
            rover.Execute("LMLMLMLMM");
            Assert.Equal("1 3 N", rover.x +" "+  rover.y +" " + rover.dir);

        }
        [Fact]
        public void TestInput2()
        {
            Rover rover = new Rover("3 3 E");
            rover.Execute("MMRMMRMRRM");
            Assert.Equal("5 1 E", rover.x + " " + rover.y + " " + rover.dir);

        }
    }
}