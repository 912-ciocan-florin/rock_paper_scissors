using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Rock_Paper_Scissors
{
    public partial class GameScreen : Form
    {
        //Global variables
        private int MyScore = 0, CPUScore = 0, MyMove, CPUMove, time = 0;

        public GameScreen()
        {
            Thread trd = new Thread(new ThreadStart(SpalshRun));
            trd.Start();
            Thread.Sleep(5000);
            trd.Abort();

            InitializeComponent();
        }

        private void SpalshRun()
        {
            Application.Run(new Splash());
        }

        private void MyMove_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            //UI for your selection
            picR.Visible = false;
            picS.Visible = false;
            picP.Enabled = false;
            picP.Image = pic.Image;

            //Your selection
            if (pic == picR)
                MyMove = 0;
            if (pic == picP)
                MyMove = 1;
            if (pic == picS)
                MyMove = 2;

            //CPU's selection
            CPU_Select();

            //Result
            if (MyMove == CPUMove)
            {
                lblFinal.Text = "TIE";
            }
            else
            if((MyMove == 0 && CPUMove == 2) || (MyMove == 1 && CPUMove == 0)
                || (MyMove == 2 && CPUMove == 1))
            {
                MyScore++;
                lblFinal.Text = "WIN";
            }
            else
            {
                CPUScore++;
                lblFinal.Text = "LOSS";
            }

            //Score Table
            ScoreTable();

            //First at 3 games condition
            if (MyScore <= 3 && CPUScore <= 3)
            {
                //Waiting time
                timer1.Enabled = true;
            }
        }

        private void CPU_Select()
        {
            //Random selection of CPU
            Random rdn = new Random();
            int n = rdn.Next(0, 3);

            //Memorize the CPU's selection
            CPUMove = n;

            //Showing the CPU's selection
            picCpu.Image = imageList1.Images[n];
            picCpu.Visible = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            //Restarting score
            MyScore = CPUScore = 0;
            ScoreTable();

            //Restarting for a new game 
            picCpu.Visible = false;
            btnNew.Visible = false;
            btnExit.Visible = false;
            picR.Enabled = true;
            picP.Enabled = true;
            picS.Enabled = true;
            lblFinal.Text = "";
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Activate();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time == 3)
            {
                time = 0;
                timer1.Stop();
                if (MyScore == 3 || CPUScore == 3)
                    GameOver();
                else
                    Reset();
            }
        }

        private void ScoreTable()
        {
            //Showing the score on the score table 
            lblYou.Text = MyScore.ToString();
            lblCPU.Text = CPUScore.ToString();
        }

        private void Reset()
        {
            picR.Image = imageList1.Images[0];
            picP.Image = imageList1.Images[1];
            picS.Image = imageList1.Images[2];
            picCpu.Visible = false;
            picR.Visible = true;
            picS.Visible = true;
            picP.Enabled = true;
            lblFinal.Text = "";
        }

        private void GameOver()
        {
            Reset();

            //First at 3 winner is ...
            if (MyScore >= 3)
            {
                picCpu.Image = ilFinal.Images[0];
                lblFinal.Text = "! WINNER !";
            }
            else
            {
                picCpu.Image = ilFinal.Images[1];
                lblFinal.Text = "! LOSER !";
            }

            //Stop selection mode
            picR.Enabled = false;
            picP.Enabled = false;
            picS.Enabled = false;

            //End game options
            picCpu.Visible = true;
            btnExit.Visible = true;
            btnNew.Visible = true;
        }
    }
}

