namespace KHRandomPlayer.Forms
{
    partial class FavoritesAndHistory
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
            this.tabFavoritesAndHistory = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgFavorites = new System.Windows.Forms.DataGridView();
            this.colFav_Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFav_SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFav_AlbumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFav_Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFav_AlbumURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFav_AlbumCoverUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgHistory = new System.Windows.Forms.DataGridView();
            this.colHis_Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHis_SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHis_AlbumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHis_Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHis_AlbumUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHis_AlbumCoverUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddToQueue = new System.Windows.Forms.Button();
            this.tabFavoritesAndHistory.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFavorites)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFavoritesAndHistory
            // 
            this.tabFavoritesAndHistory.Controls.Add(this.tabPage1);
            this.tabFavoritesAndHistory.Controls.Add(this.tabPage2);
            this.tabFavoritesAndHistory.Location = new System.Drawing.Point(0, 0);
            this.tabFavoritesAndHistory.Name = "tabFavoritesAndHistory";
            this.tabFavoritesAndHistory.SelectedIndex = 0;
            this.tabFavoritesAndHistory.Size = new System.Drawing.Size(517, 252);
            this.tabFavoritesAndHistory.TabIndex = 0;
            this.tabFavoritesAndHistory.SelectedIndexChanged += new System.EventHandler(this.tabFavoritesAndHistory_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgFavorites);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(509, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Favorites";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgFavorites
            // 
            this.dgFavorites.AllowUserToAddRows = false;
            this.dgFavorites.AllowUserToResizeColumns = false;
            this.dgFavorites.AllowUserToResizeRows = false;
            this.dgFavorites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFavorites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFav_Url,
            this.colFav_SongName,
            this.colFav_AlbumName,
            this.colFav_Duration,
            this.colFav_AlbumURL,
            this.colFav_AlbumCoverUrl});
            this.dgFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFavorites.Location = new System.Drawing.Point(3, 3);
            this.dgFavorites.MultiSelect = false;
            this.dgFavorites.Name = "dgFavorites";
            this.dgFavorites.ReadOnly = true;
            this.dgFavorites.RowHeadersVisible = false;
            this.dgFavorites.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgFavorites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFavorites.ShowCellErrors = false;
            this.dgFavorites.ShowCellToolTips = false;
            this.dgFavorites.ShowEditingIcon = false;
            this.dgFavorites.ShowRowErrors = false;
            this.dgFavorites.Size = new System.Drawing.Size(503, 220);
            this.dgFavorites.TabIndex = 0;
            this.dgFavorites.TabStop = false;
            this.dgFavorites.SelectionChanged += new System.EventHandler(this.tabFavoritesAndHistory_SelectedIndexChanged);
            // 
            // colFav_Url
            // 
            this.colFav_Url.HeaderText = "Url";
            this.colFav_Url.Name = "colFav_Url";
            this.colFav_Url.ReadOnly = true;
            this.colFav_Url.Visible = false;
            // 
            // colFav_SongName
            // 
            this.colFav_SongName.FillWeight = 200F;
            this.colFav_SongName.HeaderText = "Song name";
            this.colFav_SongName.Name = "colFav_SongName";
            this.colFav_SongName.ReadOnly = true;
            this.colFav_SongName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFav_SongName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFav_SongName.Width = 200;
            // 
            // colFav_AlbumName
            // 
            this.colFav_AlbumName.FillWeight = 200F;
            this.colFav_AlbumName.HeaderText = "Album name";
            this.colFav_AlbumName.Name = "colFav_AlbumName";
            this.colFav_AlbumName.ReadOnly = true;
            this.colFav_AlbumName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFav_AlbumName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFav_AlbumName.Width = 200;
            // 
            // colFav_Duration
            // 
            this.colFav_Duration.HeaderText = "Duration";
            this.colFav_Duration.Name = "colFav_Duration";
            this.colFav_Duration.ReadOnly = true;
            this.colFav_Duration.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFav_Duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFav_AlbumURL
            // 
            this.colFav_AlbumURL.HeaderText = "Album URL";
            this.colFav_AlbumURL.Name = "colFav_AlbumURL";
            this.colFav_AlbumURL.ReadOnly = true;
            this.colFav_AlbumURL.Visible = false;
            // 
            // colFav_AlbumCoverUrl
            // 
            this.colFav_AlbumCoverUrl.HeaderText = "Album Cover URL";
            this.colFav_AlbumCoverUrl.Name = "colFav_AlbumCoverUrl";
            this.colFav_AlbumCoverUrl.ReadOnly = true;
            this.colFav_AlbumCoverUrl.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgHistory);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(509, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgHistory
            // 
            this.dgHistory.AllowUserToAddRows = false;
            this.dgHistory.AllowUserToResizeColumns = false;
            this.dgHistory.AllowUserToResizeRows = false;
            this.dgHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHis_Url,
            this.colHis_SongName,
            this.colHis_AlbumName,
            this.colHis_Duration,
            this.colHis_AlbumUrl,
            this.colHis_AlbumCoverUrl});
            this.dgHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHistory.Location = new System.Drawing.Point(3, 3);
            this.dgHistory.MultiSelect = false;
            this.dgHistory.Name = "dgHistory";
            this.dgHistory.ReadOnly = true;
            this.dgHistory.RowHeadersVisible = false;
            this.dgHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHistory.ShowCellErrors = false;
            this.dgHistory.ShowCellToolTips = false;
            this.dgHistory.ShowEditingIcon = false;
            this.dgHistory.ShowRowErrors = false;
            this.dgHistory.Size = new System.Drawing.Size(503, 220);
            this.dgHistory.TabIndex = 2;
            this.dgHistory.TabStop = false;
            this.dgHistory.SelectionChanged += new System.EventHandler(this.tabFavoritesAndHistory_SelectedIndexChanged);
            // 
            // colHis_Url
            // 
            this.colHis_Url.HeaderText = "Url";
            this.colHis_Url.Name = "colHis_Url";
            this.colHis_Url.ReadOnly = true;
            this.colHis_Url.Visible = false;
            // 
            // colHis_SongName
            // 
            this.colHis_SongName.FillWeight = 200F;
            this.colHis_SongName.HeaderText = "Song name";
            this.colHis_SongName.Name = "colHis_SongName";
            this.colHis_SongName.ReadOnly = true;
            this.colHis_SongName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colHis_SongName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colHis_SongName.Width = 200;
            // 
            // colHis_AlbumName
            // 
            this.colHis_AlbumName.FillWeight = 200F;
            this.colHis_AlbumName.HeaderText = "Album name";
            this.colHis_AlbumName.Name = "colHis_AlbumName";
            this.colHis_AlbumName.ReadOnly = true;
            this.colHis_AlbumName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colHis_AlbumName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colHis_AlbumName.Width = 200;
            // 
            // colHis_Duration
            // 
            this.colHis_Duration.HeaderText = "Duration";
            this.colHis_Duration.Name = "colHis_Duration";
            this.colHis_Duration.ReadOnly = true;
            this.colHis_Duration.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colHis_Duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colHis_AlbumUrl
            // 
            this.colHis_AlbumUrl.HeaderText = "Album URL";
            this.colHis_AlbumUrl.Name = "colHis_AlbumUrl";
            this.colHis_AlbumUrl.ReadOnly = true;
            this.colHis_AlbumUrl.Visible = false;
            // 
            // colHis_AlbumCoverUrl
            // 
            this.colHis_AlbumCoverUrl.HeaderText = "Album Cover URL";
            this.colHis_AlbumCoverUrl.Name = "colHis_AlbumCoverUrl";
            this.colHis_AlbumCoverUrl.ReadOnly = true;
            this.colHis_AlbumCoverUrl.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(7, 254);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(248, 254);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddToQueue
            // 
            this.btnAddToQueue.Location = new System.Drawing.Point(382, 254);
            this.btnAddToQueue.Name = "btnAddToQueue";
            this.btnAddToQueue.Size = new System.Drawing.Size(128, 23);
            this.btnAddToQueue.TabIndex = 3;
            this.btnAddToQueue.Text = "Add to queue";
            this.btnAddToQueue.UseVisualStyleBackColor = true;
            this.btnAddToQueue.Click += new System.EventHandler(this.btnAddToQueue_Click);
            // 
            // FavoritesAndHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(517, 287);
            this.Controls.Add(this.btnAddToQueue);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabFavoritesAndHistory);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FavoritesAndHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Favorites & History";
            this.Load += new System.EventHandler(this.FavoritesAndHistory_Load);
            this.tabFavoritesAndHistory.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFavorites)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabFavoritesAndHistory;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource songModelBindingSource;
        private System.Windows.Forms.DataGridView dgFavorites;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddToQueue;
        private System.Windows.Forms.DataGridView dgHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFav_Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFav_SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFav_AlbumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFav_Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFav_AlbumURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFav_AlbumCoverUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHis_Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHis_SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHis_AlbumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHis_Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHis_AlbumUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHis_AlbumCoverUrl;
    }
}