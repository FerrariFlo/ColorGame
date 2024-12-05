namespace INF_SEM_ColorGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblWord = new Label();
            btnRed = new Button();
            btnBlue = new Button();
            btnGreen = new Button();
            btnYellow = new Button();
            btnStart = new Button();
            tmrStart = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            lblCountdown = new Label();
            btnViolet = new Button();
            lblpoints = new Label();
            lblAttempts = new Label();
            lblBestTime = new Label();
            lblPreviousTime = new Label();
            lblAverageTime = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnClose = new Button();
            txtPlayerName = new TextBox();
            lvScoreboard = new ListView();
            clmPlayer = new ColumnHeader();
            clmScore = new ColumnHeader();
            clmBestTime = new ColumnHeader();
            clmAverageTime = new ColumnHeader();
            btnCheckname = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // lblWord
            // 
            lblWord.BackColor = SystemColors.ControlLight;
            lblWord.BorderStyle = BorderStyle.Fixed3D;
            lblWord.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWord.Location = new Point(874, 241);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(600, 120);
            lblWord.TabIndex = 0;
            lblWord.Text = "Get Ready!";
            lblWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            btnRed.Enabled = false;
            btnRed.FlatAppearance.BorderColor = Color.Black;
            btnRed.FlatAppearance.BorderSize = 5;
            btnRed.FlatStyle = FlatStyle.Flat;
            btnRed.ForeColor = SystemColors.ActiveCaptionText;
            btnRed.Location = new Point(874, 439);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(275, 120);
            btnRed.TabIndex = 1;
            btnRed.Text = " ";
            btnRed.UseVisualStyleBackColor = false;
            btnRed.Click += ButtonClick;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.Blue;
            btnBlue.Enabled = false;
            btnBlue.FlatAppearance.BorderColor = Color.Black;
            btnBlue.FlatAppearance.BorderSize = 5;
            btnBlue.FlatStyle = FlatStyle.Flat;
            btnBlue.Location = new Point(1199, 439);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(275, 120);
            btnBlue.TabIndex = 2;
            btnBlue.Text = " ";
            btnBlue.UseVisualStyleBackColor = false;
            btnBlue.Click += ButtonClick;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Green;
            btnGreen.Enabled = false;
            btnGreen.FlatAppearance.BorderColor = Color.Black;
            btnGreen.FlatAppearance.BorderSize = 5;
            btnGreen.FlatStyle = FlatStyle.Flat;
            btnGreen.Location = new Point(1199, 596);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(275, 120);
            btnGreen.TabIndex = 4;
            btnGreen.Text = " ";
            btnGreen.UseVisualStyleBackColor = false;
            btnGreen.Click += ButtonClick;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.Yellow;
            btnYellow.Enabled = false;
            btnYellow.FlatAppearance.BorderColor = Color.Black;
            btnYellow.FlatAppearance.BorderSize = 5;
            btnYellow.FlatStyle = FlatStyle.Flat;
            btnYellow.Location = new Point(874, 596);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(275, 120);
            btnYellow.TabIndex = 3;
            btnYellow.Text = " ";
            btnYellow.UseVisualStyleBackColor = false;
            btnYellow.Click += ButtonClick;
            // 
            // btnStart
            // 
            btnStart.Enabled = false;
            btnStart.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(1099, 932);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(169, 121);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // tmrStart
            // 
            tmrStart.Interval = 1000;
            tmrStart.Tick += tmrStart_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(1038, 18);
            label1.Name = "label1";
            label1.Size = new Size(297, 65);
            label1.TabIndex = 6;
            label1.Text = "Countdown";
            // 
            // lblCountdown
            // 
            lblCountdown.BackColor = SystemColors.ControlLight;
            lblCountdown.BorderStyle = BorderStyle.Fixed3D;
            lblCountdown.Font = new Font("Impact", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCountdown.Location = new Point(1099, 100);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(190, 120);
            lblCountdown.TabIndex = 7;
            lblCountdown.Text = " ";
            lblCountdown.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnViolet
            // 
            btnViolet.BackColor = Color.Purple;
            btnViolet.Enabled = false;
            btnViolet.FlatAppearance.BorderColor = Color.Black;
            btnViolet.FlatAppearance.BorderSize = 5;
            btnViolet.FlatStyle = FlatStyle.Flat;
            btnViolet.Location = new Point(1030, 748);
            btnViolet.Name = "btnViolet";
            btnViolet.Size = new Size(275, 120);
            btnViolet.TabIndex = 8;
            btnViolet.Text = " ";
            btnViolet.UseVisualStyleBackColor = false;
            btnViolet.Click += ButtonClick;
            // 
            // lblpoints
            // 
            lblpoints.BackColor = SystemColors.ControlLight;
            lblpoints.BorderStyle = BorderStyle.Fixed3D;
            lblpoints.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpoints.Location = new Point(1516, 249);
            lblpoints.Name = "lblpoints";
            lblpoints.Size = new Size(167, 100);
            lblpoints.TabIndex = 9;
            lblpoints.Text = " ";
            lblpoints.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAttempts
            // 
            lblAttempts.BackColor = SystemColors.ControlLight;
            lblAttempts.BorderStyle = BorderStyle.Fixed3D;
            lblAttempts.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAttempts.Location = new Point(722, 249);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(100, 100);
            lblAttempts.TabIndex = 10;
            lblAttempts.Text = " ";
            lblAttempts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBestTime
            // 
            lblBestTime.BackColor = SystemColors.ControlLight;
            lblBestTime.BorderStyle = BorderStyle.Fixed3D;
            lblBestTime.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBestTime.Location = new Point(1714, 439);
            lblBestTime.Name = "lblBestTime";
            lblBestTime.Size = new Size(228, 83);
            lblBestTime.TabIndex = 11;
            lblBestTime.Text = "0 ms";
            lblBestTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPreviousTime
            // 
            lblPreviousTime.BackColor = SystemColors.ControlLight;
            lblPreviousTime.BorderStyle = BorderStyle.Fixed3D;
            lblPreviousTime.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreviousTime.Location = new Point(1714, 540);
            lblPreviousTime.Name = "lblPreviousTime";
            lblPreviousTime.Size = new Size(228, 85);
            lblPreviousTime.TabIndex = 12;
            lblPreviousTime.Text = "0 ms";
            lblPreviousTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAverageTime
            // 
            lblAverageTime.BackColor = SystemColors.ControlLight;
            lblAverageTime.BorderStyle = BorderStyle.Fixed3D;
            lblAverageTime.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAverageTime.Location = new Point(1714, 643);
            lblAverageTime.Name = "lblAverageTime";
            lblAverageTime.Size = new Size(228, 92);
            lblAverageTime.TabIndex = 13;
            lblAverageTime.Text = "0 ms";
            lblAverageTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlLight;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1536, 439);
            label4.Name = "label4";
            label4.Size = new Size(162, 83);
            label4.TabIndex = 14;
            label4.Text = "Best:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlLight;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1536, 540);
            label2.Name = "label2";
            label2.Size = new Size(162, 85);
            label2.TabIndex = 15;
            label2.Text = "Last:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlLight;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1536, 643);
            label3.Name = "label3";
            label3.Size = new Size(162, 92);
            label3.TabIndex = 16;
            label3.Text = "Average:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(649, 155);
            label5.Name = "label5";
            label5.Size = new Size(249, 65);
            label5.TabIndex = 17;
            label5.Text = "Attempts";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(1507, 155);
            label6.Name = "label6";
            label6.Size = new Size(176, 65);
            label6.TabIndex = 18;
            label6.Text = "Points";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1950, 1001);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(169, 52);
            btnClose.TabIndex = 19;
            btnClose.Text = "&Beenden";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(68, 499);
            txtPlayerName.MaxLength = 5;
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(250, 43);
            txtPlayerName.TabIndex = 22;
            txtPlayerName.KeyDown += txtPlayerName_KeyDown;
            // 
            // lvScoreboard
            // 
            lvScoreboard.Columns.AddRange(new ColumnHeader[] { clmPlayer, clmScore, clmBestTime, clmAverageTime });
            lvScoreboard.FullRowSelect = true;
            lvScoreboard.GridLines = true;
            lvScoreboard.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvScoreboard.Location = new Point(68, 596);
            lvScoreboard.Name = "lvScoreboard";
            lvScoreboard.Size = new Size(616, 427);
            lvScoreboard.TabIndex = 23;
            lvScoreboard.UseCompatibleStateImageBehavior = false;
            lvScoreboard.View = View.Details;
            // 
            // clmPlayer
            // 
            clmPlayer.Text = "Player";
            clmPlayer.Width = 140;
            // 
            // clmScore
            // 
            clmScore.Text = "Score";
            clmScore.TextAlign = HorizontalAlignment.Center;
            clmScore.Width = 140;
            // 
            // clmBestTime
            // 
            clmBestTime.Text = "Best";
            clmBestTime.TextAlign = HorizontalAlignment.Center;
            clmBestTime.Width = 140;
            // 
            // clmAverageTime
            // 
            clmAverageTime.Text = "Average";
            clmAverageTime.TextAlign = HorizontalAlignment.Center;
            clmAverageTime.Width = 180;
            // 
            // btnCheckname
            // 
            btnCheckname.Location = new Point(348, 490);
            btnCheckname.Name = "btnCheckname";
            btnCheckname.Size = new Size(169, 52);
            btnCheckname.TabIndex = 24;
            btnCheckname.Text = "Enter";
            btnCheckname.UseVisualStyleBackColor = true;
            btnCheckname.Click += btnCheckname_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(68, 399);
            label7.Name = "label7";
            label7.Size = new Size(488, 65);
            label7.TabIndex = 25;
            label7.Text = "Enter Player Name!";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2652, 1126);
            Controls.Add(label7);
            Controls.Add(btnCheckname);
            Controls.Add(lvScoreboard);
            Controls.Add(txtPlayerName);
            Controls.Add(btnClose);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(lblAverageTime);
            Controls.Add(lblPreviousTime);
            Controls.Add(lblBestTime);
            Controls.Add(lblAttempts);
            Controls.Add(lblpoints);
            Controls.Add(btnViolet);
            Controls.Add(lblCountdown);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(btnGreen);
            Controls.Add(btnYellow);
            Controls.Add(btnBlue);
            Controls.Add(btnRed);
            Controls.Add(lblWord);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWord;
        private Button btnRed;
        private Button btnBlue;
        private Button btnGreen;
        private Button btnYellow;
        private Button btnStart;
        private System.Windows.Forms.Timer tmrStart;
        private Label label1;
        private Label lblCountdown;
        private Button btnViolet;
        private Label lblpoints;
        private Label lblAttempts;
        private Label lblBestTime;
        private Label lblPreviousTime;
        private Label lblAverageTime;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button btnClose;
        private TextBox txtPlayerName;
        private ListView lvScoreboard;
        private ColumnHeader clmPlayer;
        private ColumnHeader clmScore;
        private ColumnHeader clmBestTime;
        private ColumnHeader clmAverageTime;
        private Button btnCheckname;
        private Label label7;
    }
}
