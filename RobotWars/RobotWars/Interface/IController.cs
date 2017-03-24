using System;

namespace RobotWars
{
    public interface  IController
    {
        string RobotName { get; }
        Action Go { get; }
        Action<string, string> CreateRobot { get; }
    }
}
