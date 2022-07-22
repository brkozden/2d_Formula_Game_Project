namespace _2d_Formula_Game_Project
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
            this.line1 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.line3 = new System.Windows.Forms.Label();
            this.line4 = new System.Windows.Forms.Label();
            this.line5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.coins = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coins)).BeginInit();
            this.SuspendLayout();
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line1.Location = new System.Drawing.Point(310, 6);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(25, 150);
            this.line1.TabIndex = 0;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.line2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line2.Location = new System.Drawing.Point(310, 306);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(25, 150);
            this.line2.TabIndex = 1;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.line3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line3.Location = new System.Drawing.Point(310, 600);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(25, 150);
            this.line3.TabIndex = 2;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.Yellow;
            this.line4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line4.Location = new System.Drawing.Point(0, 0);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(25, 857);
            this.line4.TabIndex = 3;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.Yellow;
            this.line5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line5.Location = new System.Drawing.Point(625, 0);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(25, 857);
            this.line5.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblScore.Location = new System.Drawing.Point(519, 5);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 28);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score: 0";
            // 
            // player2
            // 
            this.player2.Image = global::_2d_Formula_Game_Project.Properties.Resources.black;
            this.player2.Location = new System.Drawing.Point(98, 241);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(125, 215);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2.TabIndex = 6;
            this.player2.TabStop = false;
            // 
            // player1
            // 
            this.player1.Image = global::_2d_Formula_Game_Project.Properties.Resources.black;
            this.player1.Location = new System.Drawing.Point(442, 373);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(125, 215);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1.TabIndex = 5;
            this.player1.TabStop = false;
            // 
            // coins
            // 
            this.coins.Image = global::_2d_Formula_Game_Project.Properties.Resources.Gold_Coin_PNG_Clipart_663;
            this.coins.Location = new System.Drawing.Point(177, 539);
            this.coins.Name = "coins";
            this.coins.Size = new System.Drawing.Size(57, 49);
            this.coins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coins.TabIndex = 8;
            this.coins.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(650, 600);
            this.Controls.Add(this.coins);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.line5);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Label line3;
        private System.Windows.Forms.Label line4;
        private System.Windows.Forms.Label line5;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox coins;
    }
}

