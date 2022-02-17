using System.Collections.Generic;
using Xunit;

public class MarsRoverProblemTest
{
    [Fact]
    public void Input1()
    {
        Rover rover = new Rover()
        {
            X = 1,
            Y = 2,
            Direction = Direction.N
        };

        var Area = new List<int>() { 5, 5 };
        var Rotation = "LMLMLMLMM";

        rover.Execute(Area, Rotation);

        var actualOutput = $"{rover.X} {rover.Y} {rover.Direction.ToString()}";
        var expectedOutput = "1 3 N";

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void Input2()
    {

        Rover rover = new Rover()
        {
            X = 3,
            Y = 3,
            Direction = Direction.E
        };

        var Area = new List<int>() { 5, 5 };
        var Rotation = "MMRMMRMRRM";

        rover.Execute(Area, Rotation);

        var actualOutput = $"{rover.X} {rover.Y} {rover.Direction.ToString()}";
        var expectedOutput = "5 1 E";

        Assert.Equal(expectedOutput, actualOutput);
    }
}
