namespace KHRandomPlayer
{
    partial class Settings
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
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.numMinimumSong = new System.Windows.Forms.NumericUpDown();
            this.numLimitSong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxCoverService = new System.Windows.Forms.CheckBox();
            this.btnLoadCustomBackground = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tlpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimumSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitSong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(137, 144);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tlpGeneral);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // tlpGeneral
            // 
            this.tlpGeneral.ColumnCount = 2;
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tlpGeneral.Controls.Add(this.label4, 0, 3);
            this.tlpGeneral.Controls.Add(this.numMinimumSong, 1, 1);
            this.tlpGeneral.Controls.Add(this.numLimitSong, 1, 0);
            this.tlpGeneral.Controls.Add(this.label3, 0, 2);
            this.tlpGeneral.Controls.Add(this.label2, 0, 1);
            this.tlpGeneral.Controls.Add(this.label1, 0, 0);
            this.tlpGeneral.Controls.Add(this.cBoxCoverService, 1, 2);
            this.tlpGeneral.Controls.Add(this.btnLoadCustomBackground, 1, 3);
            this.tlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeneral.Location = new System.Drawing.Point(3, 16);
            this.tlpGeneral.Name = "tlpGeneral";
            this.tlpGeneral.RowCount = 4;
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tlpGeneral.Size = new System.Drawing.Size(194, 107);
            this.tlpGeneral.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Load custom background";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numMinimumSong
            // 
            this.numMinimumSong.DecimalPlaces = 1;
            this.numMinimumSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMinimumSong.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMinimumSong.Location = new System.Drawing.Point(126, 29);
            this.numMinimumSong.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numMinimumSong.Name = "numMinimumSong";
            this.numMinimumSong.Size = new System.Drawing.Size(65, 20);
            this.numMinimumSong.TabIndex = 2;
            this.numMinimumSong.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numLimitSong
            // 
            this.numLimitSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numLimitSong.Location = new System.Drawing.Point(126, 3);
            this.numLimitSong.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numLimitSong.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numLimitSong.Name = "numLimitSong";
            this.numLimitSong.Size = new System.Drawing.Size(65, 20);
            this.numLimitSong.TabIndex = 1;
            this.numLimitSong.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cover service enabled";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minimum song length (Seconds)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Limit song queue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cBoxCoverService
            // 
            this.cBoxCoverService.AutoSize = true;
            this.cBoxCoverService.Checked = true;
            this.cBoxCoverService.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBoxCoverService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBoxCoverService.Location = new System.Drawing.Point(126, 55);
            this.cBoxCoverService.Name = "cBoxCoverService";
            this.cBoxCoverService.Size = new System.Drawing.Size(65, 20);
            this.cBoxCoverService.TabIndex = 3;
            this.cBoxCoverService.UseVisualStyleBackColor = true;
            // 
            // btnLoadCustomBackground
            // 
            this.btnLoadCustomBackground.Location = new System.Drawing.Point(126, 81);
            this.btnLoadCustomBackground.Name = "btnLoadCustomBackground";
            this.btnLoadCustomBackground.Size = new System.Drawing.Size(65, 23);
            this.btnLoadCustomBackground.TabIndex = 4;
            this.btnLoadCustomBackground.Text = "Search";
            this.btnLoadCustomBackground.UseVisualStyleBackColor = true;
            this.btnLoadCustomBackground.Click += new System.EventHandler(this.btnLoadCustomBackground_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(56, 144);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 179);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.tlpGeneral.ResumeLayout(false);
            this.tlpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimumSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitSong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tlpGeneral;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMinimumSong;
        private System.Windows.Forms.NumericUpDown numLimitSong;
        private System.Windows.Forms.CheckBox cBoxCoverService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoadCustomBackground;
    }
}