namespace RobotWars
{
    public class CoordinatePoint
    {
        public ArenaBox X { get; set; }
        public ArenaBox Y { get; set; }
        public Directions Heading { get; set; }

        public string ArenaBoxName
        {
            get
            {
                return string.Format("{0}_{1}", X.ToString(), Y.ToString());
            }
        }
    }
}
