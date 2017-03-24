namespace RobotWars
{
    public enum Directions { N = 0, E = 3, S = 6, W = 9 }

    public enum ArenaBox { Out = -1, O = 0, I, II, III, IV, V}

    public class RobotBase
    {
        public int ArenaMaxX { get; private set; }
        public int ArenaMaxY { get; private set; }
        public int Step { get; private set; }

        public RobotBase(int maxX, int maxY, int step)
        {
            ArenaMaxX = maxX;
            ArenaMaxY = maxY;
            Step = step;
        }
    }
}
