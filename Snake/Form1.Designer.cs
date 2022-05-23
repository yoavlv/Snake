
namespace Snake
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartB = new System.Windows.Forms.Button();
            this.PicGame = new System.Windows.Forms.PictureBox();
            this.ScoreL = new System.Windows.Forms.Label();
            this.HighScroeL = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.NameB = new System.Windows.Forms.TextBox();
            this.NameL = new System.Windows.Forms.Label();
            this.HighEL = new System.Windows.Forms.Label();
            this.ScoreP = new System.Windows.Forms.Label();
            this.ScoreHP = new System.Windows.Forms.Label();
            this.ScoreEver = new System.Windows.Forms.Label();
            this.HighEver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicGame)).BeginInit();
            this.SuspendLayout();
            // 
            // StartB
            // 
            this.StartB.BackColor = System.Drawing.Color.Lime;
            this.StartB.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.StartB.Location = new System.Drawing.Point(734, 205);
            this.StartB.Name = "StartB";
            this.StartB.Size = new System.Drawing.Size(133, 60);
            this.StartB.TabIndex = 0;
            this.StartB.Text = "Start";
            this.StartB.UseVisualStyleBackColor = false;
            this.StartB.Click += new System.EventHandler(this.StartGame);
            // 
            // PicGame
            // 
            this.PicGame.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PicGame.Location = new System.Drawing.Point(33, 14);
            this.PicGame.Name = "PicGame";
            this.PicGame.Size = new System.Drawing.Size(580, 560);
            this.PicGame.TabIndex = 1;
            this.PicGame.TabStop = false;
            this.PicGame.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGrafics);
            // 
            // ScoreL
            // 
            this.ScoreL.AutoSize = true;
            this.ScoreL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.ScoreL.Location = new System.Drawing.Point(729, 285);
            this.ScoreL.Name = "ScoreL";
            this.ScoreL.Size = new System.Drawing.Size(76, 25);
            this.ScoreL.TabIndex = 2;
            this.ScoreL.Text = "Score:";
            // 
            // HighScroeL
            // 
            this.HighScroeL.AutoSize = true;
            this.HighScroeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.HighScroeL.Location = new System.Drawing.Point(729, 324);
            this.HighScroeL.Name = "HighScroeL";
            this.HighScroeL.Size = new System.Drawing.Size(132, 25);
            this.HighScroeL.TabIndex = 3;
            this.HighScroeL.Text = "High Score: ";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 50;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // NameB
            // 
            this.NameB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.NameB.Location = new System.Drawing.Point(716, 70);
            this.NameB.Name = "NameB";
            this.NameB.Size = new System.Drawing.Size(151, 30);
            this.NameB.TabIndex = 4;
            this.NameB.TextChanged += new System.EventHandler(this.NameB_TextChanged);
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.NameL.Location = new System.Drawing.Point(711, 42);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(81, 25);
            this.NameL.TabIndex = 5;
            this.NameL.Text = "Name: ";
            // 
            // HighEL
            // 
            this.HighEL.AutoSize = true;
            this.HighEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.HighEL.Location = new System.Drawing.Point(739, 405);
            this.HighEL.Name = "HighEL";
            this.HighEL.Size = new System.Drawing.Size(0, 25);
            this.HighEL.TabIndex = 6;
            // 
            // ScoreP
            // 
            this.ScoreP.AutoSize = true;
            this.ScoreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.ScoreP.Location = new System.Drawing.Point(823, 285);
            this.ScoreP.Name = "ScoreP";
            this.ScoreP.Size = new System.Drawing.Size(0, 25);
            this.ScoreP.TabIndex = 7;
            // 
            // ScoreHP
            // 
            this.ScoreHP.AutoSize = true;
            this.ScoreHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.ScoreHP.Location = new System.Drawing.Point(850, 324);
            this.ScoreHP.Name = "ScoreHP";
            this.ScoreHP.Size = new System.Drawing.Size(0, 25);
            this.ScoreHP.TabIndex = 8;
            // 
            // ScoreEver
            // 
            this.ScoreEver.AutoSize = true;
            this.ScoreEver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.ScoreEver.Location = new System.Drawing.Point(639, 430);
            this.ScoreEver.Name = "ScoreEver";
            this.ScoreEver.Size = new System.Drawing.Size(211, 25);
            this.ScoreEver.TabIndex = 9;
            this.ScoreEver.Text = "Highest Score Ever: ";
            // 
            // HighEver
            // 
            this.HighEver.AutoSize = true;
            this.HighEver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.HighEver.Location = new System.Drawing.Point(856, 430);
            this.HighEver.Name = "HighEver";
            this.HighEver.Size = new System.Drawing.Size(0, 25);
            this.HighEver.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 586);
            this.Controls.Add(this.HighEver);
            this.Controls.Add(this.ScoreEver);
            this.Controls.Add(this.ScoreHP);
            this.Controls.Add(this.ScoreP);
            this.Controls.Add(this.HighEL);
            this.Controls.Add(this.NameL);
            this.Controls.Add(this.NameB);
            this.Controls.Add(this.HighScroeL);
            this.Controls.Add(this.ScoreL);
            this.Controls.Add(this.PicGame);
            this.Controls.Add(this.StartB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.PicGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button StartB;
        private System.Windows.Forms.PictureBox PicGame;
        private System.Windows.Forms.Label ScoreL;
        private System.Windows.Forms.Label HighScroeL;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.TextBox NameB;
        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.Label HighEL;
        private System.Windows.Forms.Label ScoreP;
        private System.Windows.Forms.Label ScoreHP;
        private System.Windows.Forms.Label ScoreEver;
        private System.Windows.Forms.Label HighEver;
    }
}

