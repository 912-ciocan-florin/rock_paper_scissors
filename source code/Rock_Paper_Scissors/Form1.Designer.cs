namespace Rock_Paper_Scissors
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblYou = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picR = new System.Windows.Forms.PictureBox();
            this.picP = new System.Windows.Forms.PictureBox();
            this.picS = new System.Windows.Forms.PictureBox();
            this.picCpu = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblFinal = new System.Windows.Forms.Label();
            this.ilFinal = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROCK, PAPER, SCISSORS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "THE GAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(425, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 402);
            this.panel1.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(88, 331);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNew.Location = new System.Drawing.Point(88, 292);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(95, 33);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Visible = false;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 380);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "© Ciocan Florin";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblCPU);
            this.panel2.Controls.Add(this.lblYou);
            this.panel2.Location = new System.Drawing.Point(15, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 114);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(109, 54);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 6);
            this.panel4.TabIndex = 7;
            // 
            // lblCPU
            // 
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(162, 20);
            this.lblCPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(60, 73);
            this.lblCPU.TabIndex = 6;
            this.lblCPU.Text = "0";
            this.lblCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYou
            // 
            this.lblYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYou.Location = new System.Drawing.Point(27, 20);
            this.lblYou.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(60, 73);
            this.lblYou.TabIndex = 5;
            this.lblYou.Text = "0";
            this.lblYou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(15, 82);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 41);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(158, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPU";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(23, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "YOU";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picR
            // 
            this.picR.BackColor = System.Drawing.Color.Transparent;
            this.picR.Image = ((System.Drawing.Image)(resources.GetObject("picR.Image")));
            this.picR.InitialImage = null;
            this.picR.Location = new System.Drawing.Point(11, 260);
            this.picR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picR.Name = "picR";
            this.picR.Size = new System.Drawing.Size(132, 132);
            this.picR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picR.TabIndex = 3;
            this.picR.TabStop = false;
            this.picR.Click += new System.EventHandler(this.MyMove_Click);
            // 
            // picP
            // 
            this.picP.BackColor = System.Drawing.Color.Transparent;
            this.picP.Image = ((System.Drawing.Image)(resources.GetObject("picP.Image")));
            this.picP.InitialImage = null;
            this.picP.Location = new System.Drawing.Point(147, 260);
            this.picP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picP.Name = "picP";
            this.picP.Size = new System.Drawing.Size(132, 132);
            this.picP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP.TabIndex = 4;
            this.picP.TabStop = false;
            this.picP.Click += new System.EventHandler(this.MyMove_Click);
            // 
            // picS
            // 
            this.picS.BackColor = System.Drawing.Color.Transparent;
            this.picS.Image = ((System.Drawing.Image)(resources.GetObject("picS.Image")));
            this.picS.InitialImage = null;
            this.picS.Location = new System.Drawing.Point(283, 260);
            this.picS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picS.Name = "picS";
            this.picS.Size = new System.Drawing.Size(132, 132);
            this.picS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picS.TabIndex = 5;
            this.picS.TabStop = false;
            this.picS.Click += new System.EventHandler(this.MyMove_Click);
            // 
            // picCpu
            // 
            this.picCpu.BackColor = System.Drawing.Color.Transparent;
            this.picCpu.Location = new System.Drawing.Point(147, 32);
            this.picCpu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCpu.Name = "picCpu";
            this.picCpu.Size = new System.Drawing.Size(132, 132);
            this.picCpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCpu.TabIndex = 6;
            this.picCpu.TabStop = false;
            this.picCpu.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "rock.png");
            this.imageList1.Images.SetKeyName(1, "paper.png");
            this.imageList1.Images.SetKeyName(2, "scissors.png");
            // 
            // lblFinal
            // 
            this.lblFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFinal.Location = new System.Drawing.Point(79, 190);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(268, 48);
            this.lblFinal.TabIndex = 5;
            this.lblFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilFinal
            // 
            this.ilFinal.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFinal.ImageStream")));
            this.ilFinal.TransparentColor = System.Drawing.Color.Transparent;
            this.ilFinal.Images.SetKeyName(0, "winner.png");
            this.ilFinal.Images.SetKeyName(1, "losere.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(695, 402);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.picCpu);
            this.Controls.Add(this.picS);
            this.Controls.Add(this.picP);
            this.Controls.Add(this.picR);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROCK, PAPER, SCISSORS";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picR;
        private System.Windows.Forms.PictureBox picP;
        private System.Windows.Forms.PictureBox picS;
        private System.Windows.Forms.PictureBox picCpu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.ImageList ilFinal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Timer timer1;
    }
}

