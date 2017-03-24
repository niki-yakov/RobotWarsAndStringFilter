namespace RobotWars
{
    partial class RobotWarsMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.XNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CommandLeftButton = new System.Windows.Forms.Button();
            this.CommandRightButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.O_IV = new System.Windows.Forms.Panel();
            this.I_IV = new System.Windows.Forms.Panel();
            this.II_IV = new System.Windows.Forms.Panel();
            this.III_IV = new System.Windows.Forms.Panel();
            this.IV_IV = new System.Windows.Forms.Panel();
            this.IV_III = new System.Windows.Forms.Panel();
            this.III_III = new System.Windows.Forms.Panel();
            this.II_III = new System.Windows.Forms.Panel();
            this.I_III = new System.Windows.Forms.Panel();
            this.O_III = new System.Windows.Forms.Panel();
            this.O_II = new System.Windows.Forms.Panel();
            this.I_II = new System.Windows.Forms.Panel();
            this.II_II = new System.Windows.Forms.Panel();
            this.III_II = new System.Windows.Forms.Panel();
            this.IV_II = new System.Windows.Forms.Panel();
            this.IV_I = new System.Windows.Forms.Panel();
            this.III_I = new System.Windows.Forms.Panel();
            this.II_I = new System.Windows.Forms.Panel();
            this.I_I = new System.Windows.Forms.Panel();
            this.O_I = new System.Windows.Forms.Panel();
            this.IV_O = new System.Windows.Forms.Panel();
            this.III_O = new System.Windows.Forms.Panel();
            this.II_O = new System.Windows.Forms.Panel();
            this.I_O = new System.Windows.Forms.Panel();
            this.O_O = new System.Windows.Forms.Panel();
            this.RobotsListBox = new System.Windows.Forms.ListBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.CommandTextLabel = new System.Windows.Forms.Label();
            this.CreateRobotButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CommandMoveButton = new System.Windows.Forms.Button();
            this.GoButton = new System.Windows.Forms.Button();
            this.DirectionComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MessagesListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.XNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // XNumericUpDown
            // 
            this.XNumericUpDown.Location = new System.Drawing.Point(16, 40);
            this.XNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.XNumericUpDown.Name = "XNumericUpDown";
            this.XNumericUpDown.Size = new System.Drawing.Size(39, 22);
            this.XNumericUpDown.TabIndex = 0;
            this.XNumericUpDown.ValueChanged += new System.EventHandler(this.XNumericUpDown_ValueChanged);
            // 
            // YNumericUpDown
            // 
            this.YNumericUpDown.Location = new System.Drawing.Point(61, 40);
            this.YNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.YNumericUpDown.Name = "YNumericUpDown";
            this.YNumericUpDown.Size = new System.Drawing.Size(39, 22);
            this.YNumericUpDown.TabIndex = 0;
            this.YNumericUpDown.Click += new System.EventHandler(this.YNumericUpDown_Click);
            // 
            // CommandLeftButton
            // 
            this.CommandLeftButton.Location = new System.Drawing.Point(16, 76);
            this.CommandLeftButton.Name = "CommandLeftButton";
            this.CommandLeftButton.Size = new System.Drawing.Size(42, 23);
            this.CommandLeftButton.TabIndex = 1;
            this.CommandLeftButton.Text = "L";
            this.CommandLeftButton.UseVisualStyleBackColor = true;
            this.CommandLeftButton.Click += new System.EventHandler(this.CommandLeftButton_Click);
            // 
            // CommandRightButton
            // 
            this.CommandRightButton.Location = new System.Drawing.Point(64, 76);
            this.CommandRightButton.Name = "CommandRightButton";
            this.CommandRightButton.Size = new System.Drawing.Size(42, 23);
            this.CommandRightButton.TabIndex = 1;
            this.CommandRightButton.Text = "R";
            this.CommandRightButton.UseVisualStyleBackColor = true;
            this.CommandRightButton.Click += new System.EventHandler(this.CommandRightButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.O_IV);
            this.panel1.Controls.Add(this.I_IV);
            this.panel1.Controls.Add(this.II_IV);
            this.panel1.Controls.Add(this.III_IV);
            this.panel1.Controls.Add(this.IV_IV);
            this.panel1.Controls.Add(this.IV_III);
            this.panel1.Controls.Add(this.III_III);
            this.panel1.Controls.Add(this.II_III);
            this.panel1.Controls.Add(this.I_III);
            this.panel1.Controls.Add(this.O_III);
            this.panel1.Controls.Add(this.O_II);
            this.panel1.Controls.Add(this.I_II);
            this.panel1.Controls.Add(this.II_II);
            this.panel1.Controls.Add(this.III_II);
            this.panel1.Controls.Add(this.IV_II);
            this.panel1.Controls.Add(this.IV_I);
            this.panel1.Controls.Add(this.III_I);
            this.panel1.Controls.Add(this.II_I);
            this.panel1.Controls.Add(this.I_I);
            this.panel1.Controls.Add(this.O_I);
            this.panel1.Controls.Add(this.IV_O);
            this.panel1.Controls.Add(this.III_O);
            this.panel1.Controls.Add(this.II_O);
            this.panel1.Controls.Add(this.I_O);
            this.panel1.Controls.Add(this.O_O);
            this.panel1.Location = new System.Drawing.Point(14, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 212);
            this.panel1.TabIndex = 3;
            // 
            // O_IV
            // 
            this.O_IV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.O_IV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.O_IV.Location = new System.Drawing.Point(6, 8);
            this.O_IV.Name = "O_IV";
            this.O_IV.Size = new System.Drawing.Size(38, 28);
            this.O_IV.TabIndex = 1;
            // 
            // I_IV
            // 
            this.I_IV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.I_IV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.I_IV.Location = new System.Drawing.Point(49, 8);
            this.I_IV.Name = "I_IV";
            this.I_IV.Size = new System.Drawing.Size(38, 28);
            this.I_IV.TabIndex = 1;
            // 
            // II_IV
            // 
            this.II_IV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.II_IV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.II_IV.Location = new System.Drawing.Point(90, 8);
            this.II_IV.Name = "II_IV";
            this.II_IV.Size = new System.Drawing.Size(38, 28);
            this.II_IV.TabIndex = 1;
            // 
            // III_IV
            // 
            this.III_IV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.III_IV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.III_IV.Location = new System.Drawing.Point(134, 8);
            this.III_IV.Name = "III_IV";
            this.III_IV.Size = new System.Drawing.Size(38, 28);
            this.III_IV.TabIndex = 1;
            // 
            // IV_IV
            // 
            this.IV_IV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IV_IV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IV_IV.Location = new System.Drawing.Point(178, 8);
            this.IV_IV.Name = "IV_IV";
            this.IV_IV.Size = new System.Drawing.Size(38, 28);
            this.IV_IV.TabIndex = 1;
            // 
            // IV_III
            // 
            this.IV_III.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IV_III.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IV_III.Location = new System.Drawing.Point(178, 50);
            this.IV_III.Name = "IV_III";
            this.IV_III.Size = new System.Drawing.Size(38, 28);
            this.IV_III.TabIndex = 1;
            // 
            // III_III
            // 
            this.III_III.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.III_III.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.III_III.Location = new System.Drawing.Point(134, 50);
            this.III_III.Name = "III_III";
            this.III_III.Size = new System.Drawing.Size(38, 28);
            this.III_III.TabIndex = 1;
            // 
            // II_III
            // 
            this.II_III.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.II_III.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.II_III.Location = new System.Drawing.Point(90, 50);
            this.II_III.Name = "II_III";
            this.II_III.Size = new System.Drawing.Size(38, 28);
            this.II_III.TabIndex = 1;
            // 
            // I_III
            // 
            this.I_III.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.I_III.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.I_III.Location = new System.Drawing.Point(49, 50);
            this.I_III.Name = "I_III";
            this.I_III.Size = new System.Drawing.Size(38, 28);
            this.I_III.TabIndex = 1;
            // 
            // O_III
            // 
            this.O_III.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.O_III.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.O_III.Location = new System.Drawing.Point(6, 50);
            this.O_III.Name = "O_III";
            this.O_III.Size = new System.Drawing.Size(38, 28);
            this.O_III.TabIndex = 1;
            // 
            // O_II
            // 
            this.O_II.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.O_II.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.O_II.Location = new System.Drawing.Point(6, 92);
            this.O_II.Name = "O_II";
            this.O_II.Size = new System.Drawing.Size(38, 28);
            this.O_II.TabIndex = 1;
            // 
            // I_II
            // 
            this.I_II.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.I_II.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.I_II.Location = new System.Drawing.Point(49, 92);
            this.I_II.Name = "I_II";
            this.I_II.Size = new System.Drawing.Size(38, 28);
            this.I_II.TabIndex = 1;
            // 
            // II_II
            // 
            this.II_II.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.II_II.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.II_II.Location = new System.Drawing.Point(90, 92);
            this.II_II.Name = "II_II";
            this.II_II.Size = new System.Drawing.Size(38, 28);
            this.II_II.TabIndex = 1;
            // 
            // III_II
            // 
            this.III_II.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.III_II.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.III_II.Location = new System.Drawing.Point(134, 92);
            this.III_II.Name = "III_II";
            this.III_II.Size = new System.Drawing.Size(38, 28);
            this.III_II.TabIndex = 1;
            // 
            // IV_II
            // 
            this.IV_II.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IV_II.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IV_II.Location = new System.Drawing.Point(178, 92);
            this.IV_II.Name = "IV_II";
            this.IV_II.Size = new System.Drawing.Size(38, 28);
            this.IV_II.TabIndex = 1;
            // 
            // IV_I
            // 
            this.IV_I.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IV_I.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IV_I.Location = new System.Drawing.Point(178, 134);
            this.IV_I.Name = "IV_I";
            this.IV_I.Size = new System.Drawing.Size(38, 28);
            this.IV_I.TabIndex = 1;
            // 
            // III_I
            // 
            this.III_I.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.III_I.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.III_I.Location = new System.Drawing.Point(134, 134);
            this.III_I.Name = "III_I";
            this.III_I.Size = new System.Drawing.Size(38, 28);
            this.III_I.TabIndex = 1;
            // 
            // II_I
            // 
            this.II_I.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.II_I.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.II_I.Location = new System.Drawing.Point(90, 134);
            this.II_I.Name = "II_I";
            this.II_I.Size = new System.Drawing.Size(38, 28);
            this.II_I.TabIndex = 1;
            // 
            // I_I
            // 
            this.I_I.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.I_I.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.I_I.Location = new System.Drawing.Point(49, 134);
            this.I_I.Name = "I_I";
            this.I_I.Size = new System.Drawing.Size(38, 28);
            this.I_I.TabIndex = 1;
            // 
            // O_I
            // 
            this.O_I.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.O_I.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.O_I.Location = new System.Drawing.Point(6, 134);
            this.O_I.Name = "O_I";
            this.O_I.Size = new System.Drawing.Size(38, 28);
            this.O_I.TabIndex = 1;
            // 
            // IV_O
            // 
            this.IV_O.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IV_O.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IV_O.Location = new System.Drawing.Point(178, 176);
            this.IV_O.Name = "IV_O";
            this.IV_O.Size = new System.Drawing.Size(38, 28);
            this.IV_O.TabIndex = 1;
            // 
            // III_O
            // 
            this.III_O.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.III_O.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.III_O.Location = new System.Drawing.Point(134, 176);
            this.III_O.Name = "III_O";
            this.III_O.Size = new System.Drawing.Size(38, 28);
            this.III_O.TabIndex = 1;
            // 
            // II_O
            // 
            this.II_O.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.II_O.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.II_O.Location = new System.Drawing.Point(90, 176);
            this.II_O.Name = "II_O";
            this.II_O.Size = new System.Drawing.Size(38, 28);
            this.II_O.TabIndex = 1;
            // 
            // I_O
            // 
            this.I_O.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.I_O.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.I_O.Location = new System.Drawing.Point(49, 176);
            this.I_O.Name = "I_O";
            this.I_O.Size = new System.Drawing.Size(38, 28);
            this.I_O.TabIndex = 1;
            // 
            // O_O
            // 
            this.O_O.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.O_O.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.O_O.Location = new System.Drawing.Point(6, 176);
            this.O_O.Name = "O_O";
            this.O_O.Size = new System.Drawing.Size(38, 28);
            this.O_O.TabIndex = 0;
            // 
            // RobotsListBox
            // 
            this.RobotsListBox.FormattingEnabled = true;
            this.RobotsListBox.ItemHeight = 16;
            this.RobotsListBox.Location = new System.Drawing.Point(256, 204);
            this.RobotsListBox.Name = "RobotsListBox";
            this.RobotsListBox.Size = new System.Drawing.Size(266, 212);
            this.RobotsListBox.TabIndex = 4;
            // 
            // lblCommand
            // 
            this.lblCommand.AutoEllipsis = true;
            this.lblCommand.Location = new System.Drawing.Point(17, 178);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(181, 23);
            this.lblCommand.TabIndex = 5;
            this.lblCommand.Text = "Arena";
            // 
            // CommandTextLabel
            // 
            this.CommandTextLabel.AutoEllipsis = true;
            this.CommandTextLabel.Location = new System.Drawing.Point(10, 125);
            this.CommandTextLabel.Name = "CommandTextLabel";
            this.CommandTextLabel.Size = new System.Drawing.Size(181, 23);
            this.CommandTextLabel.TabIndex = 5;
            this.CommandTextLabel.Text = "CommandText";
            // 
            // CreateRobotButton
            // 
            this.CreateRobotButton.Location = new System.Drawing.Point(13, 152);
            this.CreateRobotButton.Name = "CreateRobotButton";
            this.CreateRobotButton.Size = new System.Drawing.Size(75, 23);
            this.CreateRobotButton.TabIndex = 6;
            this.CreateRobotButton.Text = "Create Robot";
            this.CreateRobotButton.UseVisualStyleBackColor = true;
            this.CreateRobotButton.Click += new System.EventHandler(this.CreateRobotButton_Click);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Location = new System.Drawing.Point(257, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Robots";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Location = new System.Drawing.Point(10, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Command";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "R";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CommandRightButton_Click);
            // 
            // CommandMoveButton
            // 
            this.CommandMoveButton.Location = new System.Drawing.Point(112, 76);
            this.CommandMoveButton.Name = "CommandMoveButton";
            this.CommandMoveButton.Size = new System.Drawing.Size(42, 23);
            this.CommandMoveButton.TabIndex = 1;
            this.CommandMoveButton.Text = "M";
            this.CommandMoveButton.UseVisualStyleBackColor = true;
            this.CommandMoveButton.Click += new System.EventHandler(this.CommandMoveButton_Click);
            // 
            // GoButton
            // 
            this.GoButton.Enabled = false;
            this.GoButton.Location = new System.Drawing.Point(94, 152);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 6;
            this.GoButton.Text = "GO";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // DirectionComboBox
            // 
            this.DirectionComboBox.FormattingEnabled = true;
            this.DirectionComboBox.Location = new System.Drawing.Point(112, 39);
            this.DirectionComboBox.Name = "DirectionComboBox";
            this.DirectionComboBox.Size = new System.Drawing.Size(42, 24);
            this.DirectionComboBox.TabIndex = 7;
            this.DirectionComboBox.SelectedIndexChanged += new System.EventHandler(this.DirectionComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Location = new System.Drawing.Point(257, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Messages";
            // 
            // MessagesListBox
            // 
            this.MessagesListBox.FormattingEnabled = true;
            this.MessagesListBox.ItemHeight = 16;
            this.MessagesListBox.Location = new System.Drawing.Point(256, 39);
            this.MessagesListBox.Name = "MessagesListBox";
            this.MessagesListBox.Size = new System.Drawing.Size(266, 132);
            this.MessagesListBox.TabIndex = 8;
            // 
            // RobotWarsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 428);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MessagesListBox);
            this.Controls.Add(this.DirectionComboBox);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.CreateRobotButton);
            this.Controls.Add(this.CommandTextLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.RobotsListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommandMoveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CommandRightButton);
            this.Controls.Add(this.CommandLeftButton);
            this.Controls.Add(this.YNumericUpDown);
            this.Controls.Add(this.XNumericUpDown);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RobotWarsMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Wars";
            this.Load += new System.EventHandler(this.RobotWarsMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown XNumericUpDown;
        private System.Windows.Forms.NumericUpDown YNumericUpDown;
        private System.Windows.Forms.Button CommandLeftButton;
        private System.Windows.Forms.Button CommandRightButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel O_IV;
        private System.Windows.Forms.Panel I_IV;
        private System.Windows.Forms.Panel II_IV;
        private System.Windows.Forms.Panel III_IV;
        private System.Windows.Forms.Panel IV_IV;
        private System.Windows.Forms.Panel IV_III;
        private System.Windows.Forms.Panel III_III;
        private System.Windows.Forms.Panel II_III;
        private System.Windows.Forms.Panel I_III;
        private System.Windows.Forms.Panel O_III;
        private System.Windows.Forms.Panel O_II;
        private System.Windows.Forms.Panel I_II;
        private System.Windows.Forms.Panel II_II;
        private System.Windows.Forms.Panel III_II;
        private System.Windows.Forms.Panel IV_II;
        private System.Windows.Forms.Panel IV_I;
        private System.Windows.Forms.Panel III_I;
        private System.Windows.Forms.Panel II_I;
        private System.Windows.Forms.Panel I_I;
        private System.Windows.Forms.Panel O_I;
        private System.Windows.Forms.Panel IV_O;
        private System.Windows.Forms.Panel III_O;
        private System.Windows.Forms.Panel II_O;
        private System.Windows.Forms.Panel I_O;
        private System.Windows.Forms.Panel O_O;
        private System.Windows.Forms.ListBox RobotsListBox;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Label CommandTextLabel;
        private System.Windows.Forms.Button CreateRobotButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CommandMoveButton;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ComboBox DirectionComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox MessagesListBox;
    }
}

