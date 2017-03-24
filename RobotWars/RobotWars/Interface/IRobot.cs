using System;
using System.Collections.Generic;

namespace RobotWars
{
    public interface IRobot
    {
        Queue<CoordinatePoint> Steps { get; set; }
        CoordinatePoint DeployPoint { get; set; }
        CoordinatePoint FinalPoint { get; set; }
        string Command { get; }
        string RobotName { get; }
        event Action<string> Move;
        void Deploy(string deployText, string commandText);
        void Go();
    }
}
