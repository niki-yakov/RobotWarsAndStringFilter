using System;
namespace RobotWars
{
    public enum Command { L, R, M }
    public class Controller : IController
    {
        private Arena Arena { get; set; }
        private IView View { get; set; }
        public Action Go { get; private set; }
        public Action<string, string> CreateRobot { get; private set; }

        public string RobotName { get { return Arena.CurrentRobot.RobotName; } }

        public Controller(IView view)
        {
            Arena = new Arena();
            Go = GoMethod;
            CreateRobot = CreateRobotMethod;
            View = view;
        }

        public void CreateRobotMethod(string deployLocation, string command)
        {
            Arena.CurrentRobot = new Robot();
            Arena.CurrentRobot.Move += (string ctrl) => View.MoveOnArena(ctrl);
            Arena.CurrentRobot.Deploy(deployLocation, command);
        }

        public void GoMethod()
        {
            Arena.CurrentRobot.Go();
            Arena.Robots.Add(Arena.CurrentRobot);
        }
    }
}
