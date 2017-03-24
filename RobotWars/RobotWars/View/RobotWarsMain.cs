using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RobotWars
{
    public partial class RobotWarsMain : Form, IView
    {
        private IController controller = null;
        private StringBuilder commandBuilder = new StringBuilder();
        private Color originalColor = Color.White;
        private static Random rand = new Random(2);
        private Color robotColor;
        public RobotWarsMain()
        {
            InitializeComponent();
            controller = new Controller(this);
        }

        public void MoveOnArena(string boxName)
        {
            var ctrl = this.Controls.Find(boxName, true);
            if (ctrl.Length == 0)
            {
                AddMessage(MessageConstants.RobotHitArenaWall, controller.RobotName);
            }
            else
            {
                ctrl[0].BackColor = robotColor;
                ctrl[0].Refresh();
                ctrl[0].Update();
            }
        }

        private void RobotWarsMain_Load(object sender, EventArgs e)
        {
            DirectionComboBox.Items.AddRange(new object[] {
                Directions.E.ToString(),
                Directions.W.ToString(),
                Directions.N.ToString(),
                Directions.S.ToString()
                });
        }

        private Color GetNextColor(int seed)
        {
            Color c = Color.White;

            switch(seed)
            {
                case 1: c = Color.AliceBlue; break;
                case 2: c = Color.Aqua; break;
                case 3: c = Color.Beige; break;
                case 4: c = Color.Black; break;
                case 5: c = Color.Blue; break;
                case 6: c = Color.Cyan; break;
                case 7: c = Color.DarkRed; break;
                case 8: c = Color.DarkViolet; break;
                case 9: c = Color.Green; break;
            }

            return c;
        }

        private void CommandLeftButton_Click(object sender, EventArgs e)
        {
            AppendCommand(Command.L);
            AddMessage(MessageConstants.CommandAdded, Command.L.ToString());
        }

        private void CommandRightButton_Click(object sender, EventArgs e)
        {
            AppendCommand(Command.R);
            AddMessage(MessageConstants.CommandAdded, Command.R.ToString());
        }

        private void CommandMoveButton_Click(object sender, EventArgs e)
        {
            AppendCommand(Command.M);
            AddMessage(MessageConstants.CommandAdded, Command.M.ToString());
        }
        private void DirectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex != -1)
            {
                AddMessage(MessageConstants.DirectionUpdatred, ((ComboBox)sender).Text);
            }
        }

        private void YNumericUpDown_Click(object sender, EventArgs e)
        {
            AddMessage(MessageConstants.DirectionUpdatred, ((NumericUpDown)sender).Value.ToString());
        }
        private void XNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            AddMessage(MessageConstants.DirectionUpdatred, ((NumericUpDown)sender).Value.ToString());
        }
        private void AppendCommand(Command command)
        {
            CommandTextLabel.Text = commandBuilder.Append(command.ToString()).ToString();
        }

        private void CreateRobotButton_Click(object sender, EventArgs e)
        {
            controller.CreateRobot(string.Format("{0} {1} {2}",
                XNumericUpDown.Value.ToString(), YNumericUpDown.Value.ToString(), DirectionComboBox.Text),
                CommandTextLabel.Text);
            GoButton.Enabled = true;
            RobotsListBox.Items.Add(controller.RobotName);
            robotColor = GetNextColor(rand.Next(1, 9));
            AddMessage(MessageConstants.RobotCreated);
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            AddMessage(MessageConstants.RobotStarted);

            controller.Go();
            ClearCurrentRobot();
        }

        private void ClearCurrentRobot()
        {
            GoButton.Enabled = false;
            XNumericUpDown.Value = 0;
            YNumericUpDown.Value = 0;
            DirectionComboBox.SelectedIndex = -1;
            CommandTextLabel.Text = string.Empty;
            commandBuilder.Clear();
        }

        private void AddMessage(string message)
        {
            MessagesListBox.Items.Insert(0, message);
        }

        private void  AddMessage(string message, string param)
        {
            AddMessage(string.Format(message, param));
        }
    }
}
