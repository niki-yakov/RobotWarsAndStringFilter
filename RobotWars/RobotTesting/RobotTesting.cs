using RobotWars;
using Xunit;

namespace RobotTesting
{
    public class RobotTesting
    {
        [Theory]
        [InlineDataAttribute("1 2 N", "LMLMLMLMM", Directions.N, ArenaBox.I, ArenaBox.II)]
        [InlineDataAttribute("3 3 E", "MMRMMRMRRM", Directions.E, ArenaBox.III, ArenaBox.III)]
        public void GivenRobotDeployMethodTesting(string deployLocation, string commandText,
                    Directions expectedHeading, ArenaBox expectedX, ArenaBox expectedY)
        {
            IRobot robot = new Robot();
            var expectedLocation = new CoordinatePoint { Heading = expectedHeading, X = expectedX, Y = expectedY };

            robot.Deploy(deployLocation, commandText);

            Assert.Equal(expectedLocation.ArenaBoxName, robot.DeployPoint.ArenaBoxName);
            Assert.Equal(expectedLocation.Heading, robot.DeployPoint.Heading);
            Assert.Equal(expectedLocation.X, robot.DeployPoint.X);
            Assert.Equal(expectedLocation.Y, robot.DeployPoint.Y);
        }

        [Theory]
        [InlineDataAttribute("1 2 N", "LMLMLMLMM", Directions.N, ArenaBox.I, ArenaBox.II, Directions.N, ArenaBox.I, ArenaBox.III)]
        [InlineDataAttribute("3 3 E", "MMRMMRMRRM", Directions.E, ArenaBox.III, ArenaBox.III, Directions.E, ArenaBox.V, ArenaBox.I)]
        public void GivenRobotGoMethodTesting(string deployLocation, string commandText, 
                    Directions expectedHeading, ArenaBox expectedX, ArenaBox expectedY,
                    Directions finalHeading, ArenaBox finalX, ArenaBox finalY)
        {
            IRobot robot = new Robot();
            var expectedLocation = new CoordinatePoint { Heading = expectedHeading, X = expectedX, Y = expectedY };
            var finalPoint = new CoordinatePoint { Heading = finalHeading, X = finalX, Y = finalY };

            robot.Deploy(deployLocation, commandText);

            robot.Go();

            Assert.Equal(expectedLocation.ArenaBoxName, robot.DeployPoint.ArenaBoxName);
            Assert.Equal(expectedLocation.Heading, robot.DeployPoint.Heading);
            Assert.Equal(expectedLocation.X, robot.DeployPoint.X);
            Assert.Equal(expectedLocation.Y, robot.DeployPoint.Y);

            Assert.Equal(finalPoint.ArenaBoxName, robot.FinalPoint.ArenaBoxName);
            Assert.Equal(finalPoint.Heading, robot.FinalPoint.Heading);
            Assert.Equal(finalPoint.X, robot.FinalPoint.X);
            Assert.Equal(finalPoint.Y, robot.FinalPoint.Y);
        }

        [Theory]
        [InlineDataAttribute("1 2 N", "LMLMLMLMM", Directions.N, ArenaBox.I, ArenaBox.II)]
        [InlineDataAttribute("3 3 E", "MMRMMRMRRM", Directions.E, ArenaBox.III, ArenaBox.III)]
        public void GivenRobotMoveEventTest(string deployLocation, string commandText,
                    Directions expectedHeading, ArenaBox expectedX, ArenaBox expectedY)
        {
            var eventRaised = false;
            IRobot robot = new Robot();
            var expectedLocation = new CoordinatePoint { Heading = expectedHeading, X = expectedX, Y = expectedY };
            robot.Move += (string obj) => eventRaised = true;
            robot.Deploy(deployLocation, commandText);

            robot.Go();

            Assert.True(eventRaised);
        }
    }
}
