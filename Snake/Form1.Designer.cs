
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
            this.StartB = new System.Windows.Forms.Button();
            this.PicGame = new System.Windows.Forms.PictureBox();
            this.ScoreL = new System.Windows.Forms.Label();
            this.HighScroeL = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicGame)).BeginInit();
            this.SuspendLayout();
            // 
            // StartB
            // 
            this.StartB.BackColor = System.Drawing.Color.Lime;
            this.StartB.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.StartB.Location = new System.Drawing.Point(737, 14);
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
            this.ScoreL.Location = new System.Drawing.Point(745, 114);
            this.ScoreL.Name = "ScoreL";
            this.ScoreL.Size = new System.Drawing.Size(94, 25);
            this.ScoreL.TabIndex = 2;
            this.ScoreL.Text = "Score: 0";
            // 
            // HighScroeL
            // 
            this.HighScroeL.AutoSize = true;
            this.HighScroeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.HighScroeL.Location = new System.Drawing.Point(745, 160);
            this.HighScroeL.Name = "HighScroeL";
            this.HighScroeL.Size = new System.Drawing.Size(144, 25);
            this.HighScroeL.TabIndex = 3;
            this.HighScroeL.Text = "High Score: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 50;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 586);
            this.Controls.Add(this.HighScroeL);
            this.Controls.Add(this.ScoreL);
            this.Controls.Add(this.PicGame);
            this.Controls.Add(this.StartB);
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
    }
}

