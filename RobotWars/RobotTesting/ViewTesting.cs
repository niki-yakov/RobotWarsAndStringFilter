using RobotWars;
using Xunit;

namespace RobotTesting
{
    public class ViewTesting
    {
        [Theory]
        [InlineDataAttribute("1 2 N", "LMLMLMLMM", "I am robot 1")]
        [InlineDataAttribute("3 3 E", "MMRMMRMRRM", "I am robot 2")]
        public void GivenAViewToCreateTheRobot(string deployLocation, string commandText, string expectedName)
        {
            IController controller = new Controller(null);
            controller.CreateRobot(deployLocation, commandText);

            Assert.Equal(expectedName, controller.RobotName);
        }
    }
}
