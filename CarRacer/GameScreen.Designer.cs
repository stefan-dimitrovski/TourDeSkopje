namespace CarRacer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timerSpeedUp = new System.Windows.Forms.Timer(this.components);
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.lbl321 = new System.Windows.Forms.Label();
            this.timer321 = new System.Windows.Forms.Timer(this.components);
            this.btnLeave = new System.Windows.Forms.Button();
            this.lblEnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 545);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(479, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 545);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.White;
            this.pb1.Location = new System.Drawing.Point(227, 0);
            this.pb1.Margin = new System.Windows.Forms.Padding(4);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(9, 114);
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.White;
            this.pb2.Location = new System.Drawing.Point(227, 171);
            this.pb2.Margin = new System.Windows.Forms.Padding(4);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(9, 114);
            this.pb2.TabIndex = 3;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.White;
            this.pb3.Location = new System.Drawing.Point(227, 343);
            this.pb3.Margin = new System.Windows.Forms.Padding(4);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(9, 114);
            this.pb3.TabIndex = 4;
            this.pb3.TabStop = false;
            // 
            // gameTime
            // 
            this.gameTime.Interval = 1;
            this.gameTime.Tick += new System.EventHandler(this.gameSpeed_Tick);
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.White;
            this.pb4.Location = new System.Drawing.Point(227, 516);
            this.pb4.Margin = new System.Windows.Forms.Padding(4);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(9, 114);
            this.pb4.TabIndex = 5;
            this.pb4.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Enabled = false;
            this.enemy1.Image = global::CarRacer.Properties.Resources.car5;
            this.enemy1.Location = new System.Drawing.Point(301, 462);
            this.enemy1.Margin = new System.Windows.Forms.Padding(4);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(49, 84);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 7;
            this.enemy1.TabStop = false;
            this.enemy1.Visible = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.Enabled = false;
            this.enemy2.Image = global::CarRacer.Properties.Resources.car4;
            this.enemy2.Location = new System.Drawing.Point(301, 230);
            this.enemy2.Margin = new System.Windows.Forms.Padding(4);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(49, 84);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 8;
            this.enemy2.TabStop = false;
            this.enemy2.Visible = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::CarRacer.Properties.Resources.car6;
            this.player.Location = new System.Drawing.Point(207, 414);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(49, 84);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 9;
            this.player.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTime.Location = new System.Drawing.Point(19, 16);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 31);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "00:00";
            this.lblTime.Visible = false;
            // 
            // timerSpeedUp
            // 
            this.timerSpeedUp.Enabled = true;
            this.timerSpeedUp.Interval = 1000;
            this.timerSpeedUp.Tick += new System.EventHandler(this.timerSpeedUp_Tick);
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Transparent;
            this.enemy3.Enabled = false;
            this.enemy3.Image = global::CarRacer.Properties.Resources.car1;
            this.enemy3.Location = new System.Drawing.Point(301, 0);
            this.enemy3.Margin = new System.Windows.Forms.Padding(4);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(49, 84);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 11;
            this.enemy3.TabStop = false;
            this.enemy3.Visible = false;
            // 
            // lbl321
            // 
            this.lbl321.BackColor = System.Drawing.Color.Transparent;
            this.lbl321.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl321.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl321.Location = new System.Drawing.Point(60, 58);
            this.lbl321.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl321.Name = "lbl321";
            this.lbl321.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl321.Size = new System.Drawing.Size(373, 345);
            this.lbl321.TabIndex = 12;
            this.lbl321.Text = "3";
            this.lbl321.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer321
            // 
            this.timer321.Enabled = true;
            this.timer321.Tick += new System.EventHandler(this.timer321_Tick);
            // 
            // btnLeave
            // 
            this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.Location = new System.Drawing.Point(162, 329);
            this.btnLeave.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(138, 74);
            this.btnLeave.TabIndex = 13;
            this.btnLeave.Text = "Return to main menu";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Visible = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEnd.Location = new System.Drawing.Point(157, 230);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(143, 32);
            this.lblEnd.TabIndex = 14;
            this.lblEnd.Text = "00:00:000";
            this.lblEnd.Visible = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(483, 533);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.lbl321);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.player);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(501, 580);
            this.MinimumSize = new System.Drawing.Size(501, 580);
            this.Name = "GameScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tour De Skopje";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerSpeedUp;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label lbl321;
        private System.Windows.Forms.Timer timer321;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Label lblEnd;
    }
}

