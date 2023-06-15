namespace RockPaperScissors
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lab_score = new System.Windows.Forms.Label();
            this.lab_time = new System.Windows.Forms.Label();
            this.lab_round = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_choose_turn = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pb_Scissors = new System.Windows.Forms.PictureBox();
            this.Pb_Paper = new System.Windows.Forms.PictureBox();
            this.Pb_Rock = new System.Windows.Forms.PictureBox();
            this.Player_PictureBox = new System.Windows.Forms.PictureBox();
            this.AI_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_score
            // 
            this.lab_score.AutoSize = true;
            this.lab_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F, System.Drawing.FontStyle.Bold);
            this.lab_score.Location = new System.Drawing.Point(361, 74);
            this.lab_score.Name = "lab_score";
            this.lab_score.Size = new System.Drawing.Size(64, 29);
            this.lab_score.TabIndex = 2;
            this.lab_score.Text = "0 - 0";
            this.lab_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_time
            // 
            this.lab_time.AutoSize = true;
            this.lab_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_time.Location = new System.Drawing.Point(382, 136);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(73, 29);
            this.lab_time.TabIndex = 3;
            this.lab_time.Text = "Time";
            this.lab_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_round
            // 
            this.lab_round.AutoSize = true;
            this.lab_round.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_round.Location = new System.Drawing.Point(334, 225);
            this.lab_round.Name = "lab_round";
            this.lab_round.Size = new System.Drawing.Size(102, 29);
            this.lab_round.TabIndex = 4;
            this.lab_round.Text = "Rounds";
            this.lab_round.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "AI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player";
            // 
            // lab_choose_turn
            // 
            this.lab_choose_turn.AutoSize = true;
            this.lab_choose_turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_choose_turn.Location = new System.Drawing.Point(295, 310);
            this.lab_choose_turn.Name = "lab_choose_turn";
            this.lab_choose_turn.Size = new System.Drawing.Size(185, 25);
            this.lab_choose_turn.TabIndex = 7;
            this.lab_choose_turn.Text = "Choose your turn:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Pb_Scissors
            // 
            this.Pb_Scissors.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Scissors.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Scissors.Image")));
            this.Pb_Scissors.Location = new System.Drawing.Point(473, 349);
            this.Pb_Scissors.Name = "Pb_Scissors";
            this.Pb_Scissors.Size = new System.Drawing.Size(70, 70);
            this.Pb_Scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Scissors.TabIndex = 10;
            this.Pb_Scissors.TabStop = false;
            this.Pb_Scissors.Click += new System.EventHandler(this.Pb_Scissors_Click);
            // 
            // Pb_Paper
            // 
            this.Pb_Paper.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Paper.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Paper.Image")));
            this.Pb_Paper.Location = new System.Drawing.Point(366, 349);
            this.Pb_Paper.Name = "Pb_Paper";
            this.Pb_Paper.Size = new System.Drawing.Size(70, 70);
            this.Pb_Paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Paper.TabIndex = 9;
            this.Pb_Paper.TabStop = false;
            this.Pb_Paper.Click += new System.EventHandler(this.Pb_Paper_Click);
            // 
            // Pb_Rock
            // 
            this.Pb_Rock.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Rock.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Rock.Image")));
            this.Pb_Rock.Location = new System.Drawing.Point(255, 349);
            this.Pb_Rock.Name = "Pb_Rock";
            this.Pb_Rock.Size = new System.Drawing.Size(70, 70);
            this.Pb_Rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Rock.TabIndex = 8;
            this.Pb_Rock.TabStop = false;
            this.Pb_Rock.Click += new System.EventHandler(this.Pb_Rock_Click);
            // 
            // Player_PictureBox
            // 
            this.Player_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Player_PictureBox.Image = global::RockPaperScissors.Properties.Resources.question_mark;
            this.Player_PictureBox.Location = new System.Drawing.Point(46, 74);
            this.Player_PictureBox.Name = "Player_PictureBox";
            this.Player_PictureBox.Size = new System.Drawing.Size(200, 200);
            this.Player_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player_PictureBox.TabIndex = 1;
            this.Player_PictureBox.TabStop = false;
            // 
            // AI_PictureBox
            // 
            this.AI_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.AI_PictureBox.Image = global::RockPaperScissors.Properties.Resources.question_mark;
            this.AI_PictureBox.Location = new System.Drawing.Point(519, 74);
            this.AI_PictureBox.Name = "AI_PictureBox";
            this.AI_PictureBox.Size = new System.Drawing.Size(200, 200);
            this.AI_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AI_PictureBox.TabIndex = 0;
            this.AI_PictureBox.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pb_Scissors);
            this.Controls.Add(this.Pb_Paper);
            this.Controls.Add(this.Pb_Rock);
            this.Controls.Add(this.lab_choose_turn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_round);
            this.Controls.Add(this.lab_time);
            this.Controls.Add(this.lab_score);
            this.Controls.Add(this.Player_PictureBox);
            this.Controls.Add(this.AI_PictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Rock-Paper-Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AI_PictureBox;
        private System.Windows.Forms.PictureBox Player_PictureBox;
        private System.Windows.Forms.Label lab_score;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Label lab_round;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_choose_turn;
        private System.Windows.Forms.PictureBox Pb_Rock;
        private System.Windows.Forms.PictureBox Pb_Paper;
        private System.Windows.Forms.PictureBox Pb_Scissors;
        private System.Windows.Forms.Timer timer1;
    }
}

