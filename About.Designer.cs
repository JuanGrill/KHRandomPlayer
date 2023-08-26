namespace KHRandomPlayer
{
    partial class About
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lLink1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lLink2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KHRandomPlayer.Properties.Resources.Pommy_loading;
            this.pictureBox1.Location = new System.Drawing.Point(171, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "KH Random Player v1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Play random songs from downloads khinsider.";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "KHRandomPlayer is created by me in collaboration with Richard S.";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 48);
            this.label4.TabIndex = 4;
            this.label4.Text = "This program is not affiliated with KHInsider in any way. Please visit the offici" +
    "al site and consider donating to maintain its servers:";
            // 
            // lLink1
            // 
            this.lLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lLink1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLink1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lLink1.Location = new System.Drawing.Point(12, 128);
            this.lLink1.Name = "lLink1";
            this.lLink1.Size = new System.Drawing.Size(174, 18);
            this.lLink1.TabIndex = 5;
            this.lLink1.Text = "https://downloads.khinsider.com/";
            this.lLink1.Click += new System.EventHandler(this.lLink1_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Want to see more of my works? Please visit:";
            // 
            // lLink2
            // 
            this.lLink2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lLink2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLink2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lLink2.Location = new System.Drawing.Point(12, 181);
            this.lLink2.Name = "lLink2";
            this.lLink2.Size = new System.Drawing.Size(134, 18);
            this.lLink2.TabIndex = 7;
            this.lLink2.Text = "https://takumiq.github.io/";
            this.lLink2.Click += new System.EventHandler(this.lLink2_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = "...and consider donating too. Thank you!";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 239);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lLink2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lLink1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lLink1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lLink2;
        private System.Windows.Forms.Label label7;
    }
}