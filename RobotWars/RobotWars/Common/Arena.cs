using System.Collections.Generic;

namespace RobotWars
{
    public class Arena
    {
        public List<IRobot> Robots = new List<IRobot>();

        public IRobot CurrentRobot { get; set; }
    }
}
