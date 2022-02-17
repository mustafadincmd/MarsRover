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
        public void Forward()
        {
            Rover rover = new Rover("1 2 N");
            rover.Forward();
            Assert.Equal(3, rover.y);

        }
    }
}