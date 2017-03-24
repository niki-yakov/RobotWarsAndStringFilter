using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotWars
{
    public class Robot : RobotBase, IRobot
    {
        public Queue<CoordinatePoint> Steps { get; set; }
        public CoordinatePoint DeployPoint { get; set; }
        public CoordinatePoint CurrentPoint { get; set; }
        public CoordinatePoint FinalPoint { get; set; }
        public string DeployText { get; private set; }
        public string Command { get; private set; }
        public event Action<string> Move;
        public static int RobotSequence { get; set; }

        public string RobotName { get { return string.Format("I am robot {0}", RobotSequence); } }

        public Robot(int arenaMaxX = 5, int arenaMaxY = 5, int step = 1) : base(arenaMaxX, arenaMaxY, step)
        {
            Steps = new Queue<CoordinatePoint>();
            Move = null;
            RobotSequence++;
        }

        public void Deploy(string deployText, string commandText)
        {
            string[] cmd = deployText.Split(' ');
            int.TryParse(cmd[0], out int x);
            int.TryParse(cmd[1], out int y);
            DeployPoint = new CoordinatePoint
            {
                X = (ArenaBox)x,
                Y = (ArenaBox)y,
                Heading = (Directions)Enum.Parse(typeof(Directions), cmd[2].ToString())
            };

            Command = commandText;
            DeployText = deployText;
        }

        public void Go()
        {
            Steps.Enqueue(DeployPoint);
            CurrentPoint = DeployPoint;
            RiseMoveEvent();
            Command.All(x =>
            {
                CurrentPoint = CreateStep(x);
                Steps.Enqueue(CurrentPoint);
                RiseMoveEvent();
                return true;
            });

            FinalPoint = CurrentPoint;
        }

        private void RiseMoveEvent()
        {
            if (Move != null)
                Move(CurrentPoint.ArenaBoxName);
        }

        private CoordinatePoint CreateStep(char x)
        {
            var point = new CoordinatePoint();
            point.Heading = CurrentPoint.Heading;
            point.X = CurrentPoint.X;
            point.Y = CurrentPoint.Y;

            switch(x)
            {
                case 'L':
                    var dir = (((int)CurrentPoint.Heading) - 3);
                    point.Heading = (Directions) (dir < 0 ? 9 : dir);
                    break;
                case 'R':
                    dir = (((int)CurrentPoint.Heading) + 3);
                    point.Heading = (Directions)(dir > 9 ? 0 : dir);
                    break;
                case 'M':
                    switch(CurrentPoint.Heading)
                    {
                        case Directions.E:
                            var mov = (((int)CurrentPoint.X) + Step);
                            point.X = (ArenaBox)GetMaxXY(mov, ArenaMaxX);
                            break;
                        case Directions.N:
                            mov = (((int)CurrentPoint.Y) + Step);
                            point.Y = (ArenaBox)GetMaxXY(mov, ArenaMaxY);
                            break;
                        case Directions.S:
                            mov = (((int)CurrentPoint.Y) - Step);
                            point.Y = (ArenaBox)GetMaxXY(mov, ArenaMaxY);
                            break;
                        case Directions.W:
                            mov = (((int)CurrentPoint.X) - Step);
                            point.X = (ArenaBox)GetMaxXY(mov, ArenaMaxX);
                            break;
                    }
                    break;
            }

            return point;
        }

        public int GetMaxXY(int mov, int axisMax)
        {
            return (mov >= 0 ? mov : (mov <= axisMax ? mov : -1));
        }
    }
}
