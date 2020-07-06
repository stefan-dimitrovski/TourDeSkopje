namespace CarRacer
{
    partial class HighScore
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
            this.lbScore = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.FormattingEnabled = true;
            this.lbScore.ItemHeight = 16;
            this.lbScore.Location = new System.Drawing.Point(16, 15);
            this.lbScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(292, 308);
            this.lbScore.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 341);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbScore);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScore";
            this.Load += new System.EventHandler(this.HighScore_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbScore;
        private System.Windows.Forms.Button button1;
    }
}