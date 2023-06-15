using System;
using System.Drawing;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Main : Form
    {
        int rounds = 3;
        bool gameover = false;
        int Random_Number = 0;
        int Global_Rounds;
        Random random = new Random();
        string AI_Turn, Player_Turn;
        int AI_Wins, Player_Wins;
        int RoundTimer = 4;
        string[] AI_turn_list = { "rock", "paper", "scissors"};

        public Main()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Player_Turn = "none";
            lab_time.Text = " 3 ";
        }
        private void Pb_Paper_Click(object sender, EventArgs e)
        {
            Player_PictureBox.Image = Properties.Resources.old_paper;
            Player_Turn = "paper";
        }

        private void Pb_Scissors_Click(object sender, EventArgs e)
        {
            Player_PictureBox.Image = Properties.Resources.scissors;
            Player_Turn = "scissors";
        }

        private void Pb_Rock_Click(object sender, EventArgs e)
        {
            Player_PictureBox.Image = Properties.Resources.stone;
            Player_Turn = "rock";
        }

        public void NextRound()
        {
            if (gameover)
            {
                return;
            }

            lab_score.Text = $"{Player_Wins} - {AI_Wins}";

            Player_Turn = "none";

            timer1.Enabled = true;

            Player_PictureBox.Image = Properties.Resources.question_mark;
            AI_PictureBox.Image = Properties.Resources.question_mark;
        }

        public void CheckGame()
        {
            if (Player_Turn == "rock" && AI_Turn == "paper")
            {

                AI_Wins += 1;
                Global_Rounds += 1;
                rounds -= 1;

                MessageBox.Show("CPU Wins, Paper Covers Rocks");

            }
            else if (Player_Turn == "scissors" && AI_Turn == "rock")
            {
                AI_Wins += 1;
                Global_Rounds += 1;
                rounds -= 1;

                MessageBox.Show("CPU Wins, Rock Breaks Scissors");
            }
            else if (Player_Turn == "paper" && AI_Turn == "scissors")
            {

                AI_Wins += 1;
                Global_Rounds += 1;
                rounds -= 1;

                MessageBox.Show("CPU Wins, Scissor cuts paper");

            }
            else if (Player_Turn == "rock" && AI_Turn == "scissors")
            {

                Player_Wins += 1;
                Global_Rounds += 1;
                rounds -= 1;

                MessageBox.Show("Player Wins, Rock Breaks Scissors");

            }
            else if (Player_Turn == "paper" && AI_Turn == "rock")
            {

                Player_Wins += 1;
                Global_Rounds += 1;
                rounds -= 1;

                MessageBox.Show("Player Wins, Paper Covers Rocks");

            }
            else if (Player_Turn == "scissors" && AI_Turn == "paper")
            {
                Player_Wins += 1;
                Global_Rounds += 1;
                rounds -= 1;

                MessageBox.Show("Player Wins, Scissors cuts paper");

            }
            else if (Player_Turn == "none")
            {
                MessageBox.Show("Make your Choice");
                Global_Rounds += 1;
                rounds -= 1;
            }
            else
            {
                MessageBox.Show("Draw");
                Global_Rounds += 1;
                rounds -= 1;
            }
            NextRound();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            RoundTimer -= 1;

            lab_time.Text = RoundTimer.ToString();
            lab_round.Text = $"Rounds: {rounds}";

            if (RoundTimer < 1)
            {
                timer1.Enabled = false;
                RoundTimer = 4;

                Random_Number = random.Next(0, AI_turn_list.Length);
                AI_Turn = AI_turn_list[Random_Number];

                switch (AI_Turn)
                {
                    case "rock":
                        AI_PictureBox.Image = Properties.Resources.stone;
                        break;
                    case "paper":
                        AI_PictureBox.Image = Properties.Resources.old_paper;
                        break;
                    case "scissors":
                        AI_PictureBox.Image = Properties.Resources.scissors;
                        break;
                }


                if (rounds > 0)
                {
                    CheckGame();
                }
                else
                {
                    if (Player_Wins > AI_Wins)
                    {
                        MessageBox.Show("Player Wins This Game");
                    }
                    else
                    {
                        MessageBox.Show("AI Wins This Game");
                    }
                    gameover = true;
                    if (Global_Rounds == 3)
                    {
                        RestartGame();
                    }
                }
            }
        }

        private void RestartGame()
        {
            Player_Wins = 0;
            AI_Wins = 0;
            rounds = 3;
            lab_score.Text = $"{Player_Wins} - {AI_Wins}";

            Player_Turn = "none";
            lab_time.Text = "3";

            timer1.Enabled = true;

            Player_PictureBox.Image = Properties.Resources.question_mark;
            AI_PictureBox.Image = Properties.Resources.question_mark;

            gameover = false;
        }
    }
}
