namespace KHRandomPlayer
{
    partial class KHRandomPlayer
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KHRandomPlayer));
            this.btnFetch = new System.Windows.Forms.Button();
            this.cmsAbout = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lSongName = new System.Windows.Forms.Label();
            this.cmsCurrentSong = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCopySongName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyAlbumName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveCover = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGoToAlbumSite = new System.Windows.Forms.ToolStripMenuItem();
            this.lAlbumName = new System.Windows.Forms.Label();
            this.fetchMusicTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pBoxCover = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNextSong = new System.Windows.Forms.Button();
            this.tlpPlaylist = new System.Windows.Forms.TableLayoutPanel();
            this.lListAlbum10 = new System.Windows.Forms.Label();
            this.lListAlbum9 = new System.Windows.Forms.Label();
            this.lListAlbum8 = new System.Windows.Forms.Label();
            this.lListAlbum7 = new System.Windows.Forms.Label();
            this.lListAlbum6 = new System.Windows.Forms.Label();
            this.lListAlbum5 = new System.Windows.Forms.Label();
            this.lListAlbum4 = new System.Windows.Forms.Label();
            this.lListAlbum3 = new System.Windows.Forms.Label();
            this.lListAlbum2 = new System.Windows.Forms.Label();
            this.lListAlbum1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lTotalSongsFetched = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lListSong10 = new System.Windows.Forms.Label();
            this.lListSong9 = new System.Windows.Forms.Label();
            this.lListSong8 = new System.Windows.Forms.Label();
            this.lListSong7 = new System.Windows.Forms.Label();
            this.lListSong6 = new System.Windows.Forms.Label();
            this.lListSong5 = new System.Windows.Forms.Label();
            this.lListSong4 = new System.Windows.Forms.Label();
            this.lListSong3 = new System.Windows.Forms.Label();
            this.lListSong2 = new System.Windows.Forms.Label();
            this.lListSong1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lListDuration1 = new System.Windows.Forms.Label();
            this.lListDuration2 = new System.Windows.Forms.Label();
            this.lListDuration3 = new System.Windows.Forms.Label();
            this.lListDuration4 = new System.Windows.Forms.Label();
            this.lListDuration5 = new System.Windows.Forms.Label();
            this.lListDuration6 = new System.Windows.Forms.Label();
            this.lListDuration7 = new System.Windows.Forms.Label();
            this.lListDuration8 = new System.Windows.Forms.Label();
            this.lListDuration9 = new System.Windows.Forms.Label();
            this.lListDuration10 = new System.Windows.Forms.Label();
            this.fetchDurationTimer = new System.Windows.Forms.Timer(this.components);
            this.lAudioDurationStatus = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.lDurationCounter = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShowPlaylist = new System.Windows.Forms.Button();
            this.fetchAlbumCoverTimer = new System.Windows.Forms.Timer(this.components);
            this.lAudioCoverStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.playSoundTrigger = new System.Windows.Forms.Timer(this.components);
            this.MediaPlayerSecret = new AxWMPLib.AxWindowsMediaPlayer();
            this.pBoxPlayerBack = new System.Windows.Forms.PictureBox();
            this.pBoxSkinPlayer = new System.Windows.Forms.PictureBox();
            this.cmsAbout.SuspendLayout();
            this.cmsCurrentSong.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCover)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tlpPlaylist.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerSecret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayerBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSkinPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFetch
            // 
            this.btnFetch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFetch.ContextMenuStrip = this.cmsAbout;
            this.btnFetch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFetch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFetch.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnFetch.FlatAppearance.BorderSize = 2;
            this.btnFetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetch.ForeColor = System.Drawing.Color.White;
            this.btnFetch.Location = new System.Drawing.Point(1, 1);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(1);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(58, 32);
            this.btnFetch.TabIndex = 4;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = false;
            this.btnFetch.Click += new System.EventHandler(this.StartFetch);
            // 
            // cmsAbout
            // 
            this.cmsAbout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.cmsAbout.Name = "cmsAbout";
            this.cmsAbout.Size = new System.Drawing.Size(108, 26);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(107, 22);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDownload.ContextMenuStrip = this.cmsAbout;
            this.btnDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDownload.Enabled = false;
            this.btnDownload.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnDownload.FlatAppearance.BorderSize = 2;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(61, 1);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(1);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(195, 32);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lSongName
            // 
            this.lSongName.BackColor = System.Drawing.Color.Transparent;
            this.lSongName.ContextMenuStrip = this.cmsCurrentSong;
            this.lSongName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lSongName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSongName.ForeColor = System.Drawing.Color.White;
            this.lSongName.Location = new System.Drawing.Point(3, 0);
            this.lSongName.Name = "lSongName";
            this.lSongName.Size = new System.Drawing.Size(343, 53);
            this.lSongName.TabIndex = 4;
            this.lSongName.Text = "Press Fetch to Play";
            this.lSongName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // cmsCurrentSong
            // 
            this.cmsCurrentSong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopySongName,
            this.tsmiCopyAlbumName,
            this.tsmiSaveCover,
            this.tsmiGoToAlbumSite});
            this.cmsCurrentSong.Name = "cmsCurrentSong";
            this.cmsCurrentSong.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsCurrentSong.Size = new System.Drawing.Size(182, 92);
            // 
            // tsmiCopySongName
            // 
            this.tsmiCopySongName.Enabled = false;
            this.tsmiCopySongName.Name = "tsmiCopySongName";
            this.tsmiCopySongName.Size = new System.Drawing.Size(181, 22);
            this.tsmiCopySongName.Text = "Copy song name";
            this.tsmiCopySongName.Click += new System.EventHandler(this.tsmiCopySongName_Click);
            // 
            // tsmiCopyAlbumName
            // 
            this.tsmiCopyAlbumName.Enabled = false;
            this.tsmiCopyAlbumName.Name = "tsmiCopyAlbumName";
            this.tsmiCopyAlbumName.Size = new System.Drawing.Size(181, 22);
            this.tsmiCopyAlbumName.Text = "Copy album name";
            this.tsmiCopyAlbumName.Click += new System.EventHandler(this.tsmiCopyAlbumName_Click);
            // 
            // tsmiSaveCover
            // 
            this.tsmiSaveCover.Enabled = false;
            this.tsmiSaveCover.Name = "tsmiSaveCover";
            this.tsmiSaveCover.Size = new System.Drawing.Size(181, 22);
            this.tsmiSaveCover.Text = "Save cover image";
            this.tsmiSaveCover.Click += new System.EventHandler(this.tsmiSaveCover_Click);
            // 
            // tsmiGoToAlbumSite
            // 
            this.tsmiGoToAlbumSite.Enabled = false;
            this.tsmiGoToAlbumSite.Name = "tsmiGoToAlbumSite";
            this.tsmiGoToAlbumSite.Size = new System.Drawing.Size(181, 22);
            this.tsmiGoToAlbumSite.Text = "Go to full album site";
            this.tsmiGoToAlbumSite.Click += new System.EventHandler(this.tsmiGoToAlbumSite_Click);
            // 
            // lAlbumName
            // 
            this.lAlbumName.BackColor = System.Drawing.Color.Transparent;
            this.lAlbumName.ContextMenuStrip = this.cmsCurrentSong;
            this.lAlbumName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAlbumName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAlbumName.ForeColor = System.Drawing.Color.White;
            this.lAlbumName.Location = new System.Drawing.Point(3, 53);
            this.lAlbumName.Name = "lAlbumName";
            this.lAlbumName.Size = new System.Drawing.Size(343, 38);
            this.lAlbumName.TabIndex = 5;
            this.lAlbumName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // fetchMusicTimer
            // 
            this.fetchMusicTimer.Interval = 1000;
            this.fetchMusicTimer.Tick += new System.EventHandler(this.fetchMusictimer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 460F));
            this.tableLayoutPanel1.ContextMenuStrip = this.cmsAbout;
            this.tableLayoutPanel1.Controls.Add(this.MediaPlayer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 193);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.ContextMenuStrip = this.cmsAbout;
            this.MediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(3, 106);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(454, 44);
            this.MediaPlayer.TabIndex = 3;
            this.MediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.MediaPlayer_PlayStateChange);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ContextMenuStrip = this.cmsCurrentSong;
            this.tableLayoutPanel3.Controls.Add(this.pBoxCover, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(454, 97);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // pBoxCover
            // 
            this.pBoxCover.BackgroundImage = global::KHRandomPlayer.Properties.Resources.PommyBadge;
            this.pBoxCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxCover.ContextMenuStrip = this.cmsCurrentSong;
            this.pBoxCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxCover.ImageLocation = "";
            this.pBoxCover.Location = new System.Drawing.Point(3, 3);
            this.pBoxCover.Name = "pBoxCover";
            this.pBoxCover.Size = new System.Drawing.Size(93, 91);
            this.pBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCover.TabIndex = 9;
            this.pBoxCover.TabStop = false;
            this.pBoxCover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lAlbumName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lSongName, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(102, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(349, 91);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ContextMenuStrip = this.cmsAbout;
            this.tableLayoutPanel5.Controls.Add(this.btnNextSong, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnDownload, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnFetch, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 156);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(454, 34);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // btnNextSong
            // 
            this.btnNextSong.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNextSong.ContextMenuStrip = this.cmsAbout;
            this.btnNextSong.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNextSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextSong.Enabled = false;
            this.btnNextSong.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnNextSong.FlatAppearance.BorderSize = 2;
            this.btnNextSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextSong.ForeColor = System.Drawing.Color.White;
            this.btnNextSong.Location = new System.Drawing.Point(258, 1);
            this.btnNextSong.Margin = new System.Windows.Forms.Padding(1);
            this.btnNextSong.Name = "btnNextSong";
            this.btnNextSong.Size = new System.Drawing.Size(195, 32);
            this.btnNextSong.TabIndex = 6;
            this.btnNextSong.Text = "Next song";
            this.btnNextSong.UseVisualStyleBackColor = false;
            this.btnNextSong.Click += new System.EventHandler(this.btnNextSong_Click);
            // 
            // tlpPlaylist
            // 
            this.tlpPlaylist.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tlpPlaylist.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpPlaylist.ColumnCount = 3;
            this.tlpPlaylist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.92617F));
            this.tlpPlaylist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.20358F));
            this.tlpPlaylist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.64653F));
            this.tlpPlaylist.ContextMenuStrip = this.cmsAbout;
            this.tlpPlaylist.Controls.Add(this.lListAlbum10, 1, 10);
            this.tlpPlaylist.Controls.Add(this.lListAlbum9, 1, 9);
            this.tlpPlaylist.Controls.Add(this.lListAlbum8, 1, 8);
            this.tlpPlaylist.Controls.Add(this.lListAlbum7, 1, 7);
            this.tlpPlaylist.Controls.Add(this.lListAlbum6, 1, 6);
            this.tlpPlaylist.Controls.Add(this.lListAlbum5, 1, 5);
            this.tlpPlaylist.Controls.Add(this.lListAlbum4, 1, 4);
            this.tlpPlaylist.Controls.Add(this.lListAlbum3, 1, 3);
            this.tlpPlaylist.Controls.Add(this.lListAlbum2, 1, 2);
            this.tlpPlaylist.Controls.Add(this.lListAlbum1, 1, 1);
            this.tlpPlaylist.Controls.Add(this.label3, 1, 0);
            this.tlpPlaylist.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tlpPlaylist.Controls.Add(this.lListSong10, 0, 10);
            this.tlpPlaylist.Controls.Add(this.lListSong9, 0, 9);
            this.tlpPlaylist.Controls.Add(this.lListSong8, 0, 8);
            this.tlpPlaylist.Controls.Add(this.lListSong7, 0, 7);
            this.tlpPlaylist.Controls.Add(this.lListSong6, 0, 6);
            this.tlpPlaylist.Controls.Add(this.lListSong5, 0, 5);
            this.tlpPlaylist.Controls.Add(this.lListSong4, 0, 4);
            this.tlpPlaylist.Controls.Add(this.lListSong3, 0, 3);
            this.tlpPlaylist.Controls.Add(this.lListSong2, 0, 2);
            this.tlpPlaylist.Controls.Add(this.lListSong1, 0, 1);
            this.tlpPlaylist.Controls.Add(this.label2, 2, 0);
            this.tlpPlaylist.Controls.Add(this.lListDuration1, 2, 1);
            this.tlpPlaylist.Controls.Add(this.lListDuration2, 2, 2);
            this.tlpPlaylist.Controls.Add(this.lListDuration3, 2, 3);
            this.tlpPlaylist.Controls.Add(this.lListDuration4, 2, 4);
            this.tlpPlaylist.Controls.Add(this.lListDuration5, 2, 5);
            this.tlpPlaylist.Controls.Add(this.lListDuration6, 2, 6);
            this.tlpPlaylist.Controls.Add(this.lListDuration7, 2, 7);
            this.tlpPlaylist.Controls.Add(this.lListDuration8, 2, 8);
            this.tlpPlaylist.Controls.Add(this.lListDuration9, 2, 9);
            this.tlpPlaylist.Controls.Add(this.lListDuration10, 2, 10);
            this.tlpPlaylist.Location = new System.Drawing.Point(521, 4);
            this.tlpPlaylist.Name = "tlpPlaylist";
            this.tlpPlaylist.RowCount = 11;
            this.tlpPlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpPlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpPlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpPlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpPlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpPlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpPlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpPlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpPlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpPlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpPlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpPlaylist.Size = new System.Drawing.Size(448, 272);
            this.tlpPlaylist.TabIndex = 9;
            this.tlpPlaylist.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            this.tlpPlaylist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListAlbum10
            // 
            this.lListAlbum10.AutoSize = true;
            this.lListAlbum10.BackColor = System.Drawing.Color.Transparent;
            this.lListAlbum10.ContextMenuStrip = this.cmsAbout;
            this.lListAlbum10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListAlbum10.ForeColor = System.Drawing.Color.White;
            this.lListAlbum10.Location = new System.Drawing.Point(178, 241);
            this.lListAlbum10.Name = "lListAlbum10";
            this.lListAlbum10.Size = new System.Drawing.Size(204, 30);
            this.lListAlbum10.TabIndex = 35;
            this.lListAlbum10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lListAlbum9
            // 
            this.lListAlbum9.AutoSize = true;
            this.lListAlbum9.BackColor = System.Drawing.Color.Transparent;
            this.lListAlbum9.ContextMenuStrip = this.cmsAbout;
            this.lListAlbum9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListAlbum9.ForeColor = System.Drawing.Color.White;
            this.lListAlbum9.Location = new System.Drawing.Point(178, 217);
            this.lListAlbum9.Name = "lListAlbum9";
            this.lListAlbum9.Size = new System.Drawing.Size(204, 23);
            this.lListAlbum9.TabIndex = 34;
            this.lListAlbum9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lListAlbum8
            // 
            this.lListAlbum8.AutoSize = true;
            this.lListAlbum8.BackColor = System.Drawing.Color.Transparent;
            this.lListAlbum8.ContextMenuStrip = this.cmsAbout;
            this.lListAlbum8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListAlbum8.ForeColor = System.Drawing.Color.White;
            this.lListAlbum8.Location = new System.Drawing.Point(178, 193);
            this.lListAlbum8.Name = "lListAlbum8";
            this.lListAlbum8.Size = new System.Drawing.Size(204, 23);
            this.lListAlbum8.TabIndex = 33;
            this.lListAlbum8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lListAlbum7
            // 
            this.lListAlbum7.AutoSize = true;
            this.lListAlbum7.BackColor = System.Drawing.Color.Transparent;
            this.lListAlbum7.ContextMenuStrip = this.cmsAbout;
            this.lListAlbum7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListAlbum7.ForeColor = System.Drawing.Color.White;
            this.lListAlbum7.Location = new System.Drawing.Point(178, 169);
            this.lListAlbum7.Name = "lListAlbum7";
            this.lListAlbum7.Size = new System.Drawing.Size(204, 23);
            this.lListAlbum7.TabIndex = 32;
            this.lListAlbum7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lListAlbum6
            // 
            this.lListAlbum6.AutoSize = true;
            this.lListAlbum6.BackColor = System.Drawing.Color.Transparent;
            this.lListAlbum6.ContextMenuStrip = this.cmsAbout;
            this.lListAlbum6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListAlbum6.ForeColor = System.Drawing.Color.White;
            this.lListAlbum6.Location = new System.Drawing.Point(178, 145);
            this.lListAlbum6.Name = "lListAlbum6";
            this.lListAlbum6.Size = new System.Drawing.Size(204, 23);
            this.lListAlbum6.TabIndex = 31;
            this.lListAlbum6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lListAlbum5
            // 
            this.lListAlbum5.AutoSize = true;
            this.lListAlbum5.BackColor = System.Drawing.Color.Transparent;
            this.lListAlbum5.ContextMenuStrip = this.cmsAbout;
            this.lListAlbum5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListAlbum5.ForeColor = System.Drawing.Color.White;
            this.lListAlbum5.Location = new System.Drawing.Point(178, 121);
            this.lListAlbum5.Name = "lListAlbum5";
            this.lListAlbum5.Size = new System.Drawing.Size(204, 23);
            this.lListAlbum5.TabIndex = 30;
            this.lListAlbum5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lListAlbum4
            // 
            this.lListAlbum4.AutoSize = true;
            this.lListAlbum4.BackColor = System.Drawing.Color.Transparent;
            this.lListAlbum4.ContextMenuStrip = this.cmsAbout;
            this.lListAlbum4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListAlbum4.ForeColor = System.Drawing.Color.White;
            this.lListAlbum4.Location = new System.Drawing.Point(178, 97);
            this.lListAlbum4.Name = "lListAlbum4";
            this.lListAlbum4.Size = new System.Drawing.Size(204, 23);
            this.lListAlbum4.TabIndex = 29;
            this.lListAlbum4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lListAlbum3
            // 
            this.lListAlbum3.AutoSize = true;
            this.lListAlbum3.BackColor = System.Drawing.Color.Transparent;
            this.lListAlbum3.ContextMenuStrip = this.cmsAbout;
            this.lListAlbum3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListAlbum3.ForeColor = System.Drawing.Color.White;
            this.lListAlbum3.Location = new System.Drawing.Point(178, 73);
            this.lListAlbum3.Name = "lListAlbum3";
            this.lListAlbum3.Size = new System.Drawing.Size(204, 23);
            this.lListAlbum3.TabIndex = 28;
            this.lListAlbum3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lListAlbum2
            // 
            this.lListAlbum2.AutoSize = true;
            this.lListAlbum2.BackColor = System.Drawing.Color.Transparent;
            this.lListAlbum2.ContextMenuStrip = this.cmsAbout;
            this.lListAlbum2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListAlbum2.ForeColor = System.Drawing.Color.White;
            this.lListAlbum2.Location = new System.Drawing.Point(178, 49);
            this.lListAlbum2.Name = "lListAlbum2";
            this.lListAlbum2.Size = new System.Drawing.Size(204, 23);
            this.lListAlbum2.TabIndex = 27;
            this.lListAlbum2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lListAlbum1
            // 
            this.lListAlbum1.AutoSize = true;
            this.lListAlbum1.BackColor = System.Drawing.Color.Transparent;
            this.lListAlbum1.ContextMenuStrip = this.cmsAbout;
            this.lListAlbum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListAlbum1.ForeColor = System.Drawing.Color.White;
            this.lListAlbum1.Location = new System.Drawing.Point(178, 25);
            this.lListAlbum1.Name = "lListAlbum1";
            this.lListAlbum1.Size = new System.Drawing.Size(204, 23);
            this.lListAlbum1.TabIndex = 26;
            this.lListAlbum1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ContextMenuStrip = this.cmsAbout;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(178, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Album";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.7485F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.2515F));
            this.tableLayoutPanel4.Controls.Add(this.lTotalSongsFetched, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(167, 17);
            this.tableLayoutPanel4.TabIndex = 21;
            // 
            // lTotalSongsFetched
            // 
            this.lTotalSongsFetched.AutoSize = true;
            this.lTotalSongsFetched.BackColor = System.Drawing.Color.Transparent;
            this.lTotalSongsFetched.ContextMenuStrip = this.cmsAbout;
            this.lTotalSongsFetched.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTotalSongsFetched.ForeColor = System.Drawing.Color.White;
            this.lTotalSongsFetched.Location = new System.Drawing.Point(45, 0);
            this.lTotalSongsFetched.Name = "lTotalSongsFetched";
            this.lTotalSongsFetched.Size = new System.Drawing.Size(119, 17);
            this.lTotalSongsFetched.TabIndex = 20;
            this.lTotalSongsFetched.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ContextMenuStrip = this.cmsAbout;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Song";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListSong10
            // 
            this.lListSong10.AutoSize = true;
            this.lListSong10.BackColor = System.Drawing.Color.Transparent;
            this.lListSong10.ContextMenuStrip = this.cmsAbout;
            this.lListSong10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListSong10.ForeColor = System.Drawing.Color.White;
            this.lListSong10.Location = new System.Drawing.Point(4, 241);
            this.lListSong10.Name = "lListSong10";
            this.lListSong10.Size = new System.Drawing.Size(167, 30);
            this.lListSong10.TabIndex = 24;
            this.lListSong10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListSong10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListSong9
            // 
            this.lListSong9.AutoSize = true;
            this.lListSong9.BackColor = System.Drawing.Color.Transparent;
            this.lListSong9.ContextMenuStrip = this.cmsAbout;
            this.lListSong9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListSong9.ForeColor = System.Drawing.Color.White;
            this.lListSong9.Location = new System.Drawing.Point(4, 217);
            this.lListSong9.Name = "lListSong9";
            this.lListSong9.Size = new System.Drawing.Size(167, 23);
            this.lListSong9.TabIndex = 22;
            this.lListSong9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListSong9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListSong8
            // 
            this.lListSong8.AutoSize = true;
            this.lListSong8.BackColor = System.Drawing.Color.Transparent;
            this.lListSong8.ContextMenuStrip = this.cmsAbout;
            this.lListSong8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListSong8.ForeColor = System.Drawing.Color.White;
            this.lListSong8.Location = new System.Drawing.Point(4, 193);
            this.lListSong8.Name = "lListSong8";
            this.lListSong8.Size = new System.Drawing.Size(167, 23);
            this.lListSong8.TabIndex = 20;
            this.lListSong8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListSong8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListSong7
            // 
            this.lListSong7.AutoSize = true;
            this.lListSong7.BackColor = System.Drawing.Color.Transparent;
            this.lListSong7.ContextMenuStrip = this.cmsAbout;
            this.lListSong7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListSong7.ForeColor = System.Drawing.Color.White;
            this.lListSong7.Location = new System.Drawing.Point(4, 169);
            this.lListSong7.Name = "lListSong7";
            this.lListSong7.Size = new System.Drawing.Size(167, 23);
            this.lListSong7.TabIndex = 18;
            this.lListSong7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListSong7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListSong6
            // 
            this.lListSong6.AutoSize = true;
            this.lListSong6.BackColor = System.Drawing.Color.Transparent;
            this.lListSong6.ContextMenuStrip = this.cmsAbout;
            this.lListSong6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListSong6.ForeColor = System.Drawing.Color.White;
            this.lListSong6.Location = new System.Drawing.Point(4, 145);
            this.lListSong6.Name = "lListSong6";
            this.lListSong6.Size = new System.Drawing.Size(167, 23);
            this.lListSong6.TabIndex = 16;
            this.lListSong6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListSong6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListSong5
            // 
            this.lListSong5.AutoSize = true;
            this.lListSong5.BackColor = System.Drawing.Color.Transparent;
            this.lListSong5.ContextMenuStrip = this.cmsAbout;
            this.lListSong5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListSong5.ForeColor = System.Drawing.Color.White;
            this.lListSong5.Location = new System.Drawing.Point(4, 121);
            this.lListSong5.Name = "lListSong5";
            this.lListSong5.Size = new System.Drawing.Size(167, 23);
            this.lListSong5.TabIndex = 14;
            this.lListSong5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListSong5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListSong4
            // 
            this.lListSong4.AutoSize = true;
            this.lListSong4.BackColor = System.Drawing.Color.Transparent;
            this.lListSong4.ContextMenuStrip = this.cmsAbout;
            this.lListSong4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListSong4.ForeColor = System.Drawing.Color.White;
            this.lListSong4.Location = new System.Drawing.Point(4, 97);
            this.lListSong4.Name = "lListSong4";
            this.lListSong4.Size = new System.Drawing.Size(167, 23);
            this.lListSong4.TabIndex = 12;
            this.lListSong4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListSong4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListSong3
            // 
            this.lListSong3.AutoSize = true;
            this.lListSong3.BackColor = System.Drawing.Color.Transparent;
            this.lListSong3.ContextMenuStrip = this.cmsAbout;
            this.lListSong3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListSong3.ForeColor = System.Drawing.Color.White;
            this.lListSong3.Location = new System.Drawing.Point(4, 73);
            this.lListSong3.Name = "lListSong3";
            this.lListSong3.Size = new System.Drawing.Size(167, 23);
            this.lListSong3.TabIndex = 6;
            this.lListSong3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListSong3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListSong2
            // 
            this.lListSong2.AutoSize = true;
            this.lListSong2.BackColor = System.Drawing.Color.Transparent;
            this.lListSong2.ContextMenuStrip = this.cmsAbout;
            this.lListSong2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListSong2.ForeColor = System.Drawing.Color.White;
            this.lListSong2.Location = new System.Drawing.Point(4, 49);
            this.lListSong2.Name = "lListSong2";
            this.lListSong2.Size = new System.Drawing.Size(167, 23);
            this.lListSong2.TabIndex = 4;
            this.lListSong2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListSong2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListSong1
            // 
            this.lListSong1.AutoSize = true;
            this.lListSong1.BackColor = System.Drawing.Color.Transparent;
            this.lListSong1.ContextMenuStrip = this.cmsAbout;
            this.lListSong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListSong1.ForeColor = System.Drawing.Color.White;
            this.lListSong1.Location = new System.Drawing.Point(4, 25);
            this.lListSong1.Name = "lListSong1";
            this.lListSong1.Size = new System.Drawing.Size(167, 23);
            this.lListSong1.TabIndex = 2;
            this.lListSong1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListSong1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ContextMenuStrip = this.cmsAbout;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duration";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListDuration1
            // 
            this.lListDuration1.AutoSize = true;
            this.lListDuration1.BackColor = System.Drawing.Color.Transparent;
            this.lListDuration1.ContextMenuStrip = this.cmsAbout;
            this.lListDuration1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListDuration1.ForeColor = System.Drawing.Color.White;
            this.lListDuration1.Location = new System.Drawing.Point(389, 25);
            this.lListDuration1.Name = "lListDuration1";
            this.lListDuration1.Size = new System.Drawing.Size(55, 23);
            this.lListDuration1.TabIndex = 3;
            this.lListDuration1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListDuration1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListDuration2
            // 
            this.lListDuration2.AutoSize = true;
            this.lListDuration2.BackColor = System.Drawing.Color.Transparent;
            this.lListDuration2.ContextMenuStrip = this.cmsAbout;
            this.lListDuration2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListDuration2.ForeColor = System.Drawing.Color.White;
            this.lListDuration2.Location = new System.Drawing.Point(389, 49);
            this.lListDuration2.Name = "lListDuration2";
            this.lListDuration2.Size = new System.Drawing.Size(55, 23);
            this.lListDuration2.TabIndex = 5;
            this.lListDuration2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListDuration2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListDuration3
            // 
            this.lListDuration3.AutoSize = true;
            this.lListDuration3.BackColor = System.Drawing.Color.Transparent;
            this.lListDuration3.ContextMenuStrip = this.cmsAbout;
            this.lListDuration3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListDuration3.ForeColor = System.Drawing.Color.White;
            this.lListDuration3.Location = new System.Drawing.Point(389, 73);
            this.lListDuration3.Name = "lListDuration3";
            this.lListDuration3.Size = new System.Drawing.Size(55, 23);
            this.lListDuration3.TabIndex = 7;
            this.lListDuration3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListDuration3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListDuration4
            // 
            this.lListDuration4.AutoSize = true;
            this.lListDuration4.BackColor = System.Drawing.Color.Transparent;
            this.lListDuration4.ContextMenuStrip = this.cmsAbout;
            this.lListDuration4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListDuration4.ForeColor = System.Drawing.Color.White;
            this.lListDuration4.Location = new System.Drawing.Point(389, 97);
            this.lListDuration4.Name = "lListDuration4";
            this.lListDuration4.Size = new System.Drawing.Size(55, 23);
            this.lListDuration4.TabIndex = 13;
            this.lListDuration4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListDuration4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListDuration5
            // 
            this.lListDuration5.AutoSize = true;
            this.lListDuration5.BackColor = System.Drawing.Color.Transparent;
            this.lListDuration5.ContextMenuStrip = this.cmsAbout;
            this.lListDuration5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListDuration5.ForeColor = System.Drawing.Color.White;
            this.lListDuration5.Location = new System.Drawing.Point(389, 121);
            this.lListDuration5.Name = "lListDuration5";
            this.lListDuration5.Size = new System.Drawing.Size(55, 23);
            this.lListDuration5.TabIndex = 15;
            this.lListDuration5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListDuration5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListDuration6
            // 
            this.lListDuration6.AutoSize = true;
            this.lListDuration6.BackColor = System.Drawing.Color.Transparent;
            this.lListDuration6.ContextMenuStrip = this.cmsAbout;
            this.lListDuration6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListDuration6.ForeColor = System.Drawing.Color.White;
            this.lListDuration6.Location = new System.Drawing.Point(389, 145);
            this.lListDuration6.Name = "lListDuration6";
            this.lListDuration6.Size = new System.Drawing.Size(55, 23);
            this.lListDuration6.TabIndex = 17;
            this.lListDuration6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListDuration6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListDuration7
            // 
            this.lListDuration7.AutoSize = true;
            this.lListDuration7.BackColor = System.Drawing.Color.Transparent;
            this.lListDuration7.ContextMenuStrip = this.cmsAbout;
            this.lListDuration7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListDuration7.ForeColor = System.Drawing.Color.White;
            this.lListDuration7.Location = new System.Drawing.Point(389, 169);
            this.lListDuration7.Name = "lListDuration7";
            this.lListDuration7.Size = new System.Drawing.Size(55, 23);
            this.lListDuration7.TabIndex = 19;
            this.lListDuration7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListDuration7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListDuration8
            // 
            this.lListDuration8.AutoSize = true;
            this.lListDuration8.BackColor = System.Drawing.Color.Transparent;
            this.lListDuration8.ContextMenuStrip = this.cmsAbout;
            this.lListDuration8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListDuration8.ForeColor = System.Drawing.Color.White;
            this.lListDuration8.Location = new System.Drawing.Point(389, 193);
            this.lListDuration8.Name = "lListDuration8";
            this.lListDuration8.Size = new System.Drawing.Size(55, 23);
            this.lListDuration8.TabIndex = 21;
            this.lListDuration8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListDuration8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListDuration9
            // 
            this.lListDuration9.AutoSize = true;
            this.lListDuration9.BackColor = System.Drawing.Color.Transparent;
            this.lListDuration9.ContextMenuStrip = this.cmsAbout;
            this.lListDuration9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListDuration9.ForeColor = System.Drawing.Color.White;
            this.lListDuration9.Location = new System.Drawing.Point(389, 217);
            this.lListDuration9.Name = "lListDuration9";
            this.lListDuration9.Size = new System.Drawing.Size(55, 23);
            this.lListDuration9.TabIndex = 23;
            this.lListDuration9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListDuration9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lListDuration10
            // 
            this.lListDuration10.AutoSize = true;
            this.lListDuration10.BackColor = System.Drawing.Color.Transparent;
            this.lListDuration10.ContextMenuStrip = this.cmsAbout;
            this.lListDuration10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lListDuration10.ForeColor = System.Drawing.Color.White;
            this.lListDuration10.Location = new System.Drawing.Point(389, 241);
            this.lListDuration10.Name = "lListDuration10";
            this.lListDuration10.Size = new System.Drawing.Size(55, 30);
            this.lListDuration10.TabIndex = 25;
            this.lListDuration10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lListDuration10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // fetchDurationTimer
            // 
            this.fetchDurationTimer.Interval = 1000;
            this.fetchDurationTimer.Tick += new System.EventHandler(this.fetchDurationTimer_Tick);
            // 
            // lAudioDurationStatus
            // 
            this.lAudioDurationStatus.AutoSize = true;
            this.lAudioDurationStatus.BackColor = System.Drawing.Color.Transparent;
            this.lAudioDurationStatus.ContextMenuStrip = this.cmsAbout;
            this.lAudioDurationStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lAudioDurationStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAudioDurationStatus.ForeColor = System.Drawing.Color.White;
            this.lAudioDurationStatus.Location = new System.Drawing.Point(4, 1);
            this.lAudioDurationStatus.Name = "lAudioDurationStatus";
            this.lAudioDurationStatus.Size = new System.Drawing.Size(440, 15);
            this.lAudioDurationStatus.TabIndex = 12;
            this.lAudioDurationStatus.Text = "Duration ready";
            this.lAudioDurationStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lAudioDurationStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.BackColor = System.Drawing.Color.Black;
            this.lStatus.ContextMenuStrip = this.cmsAbout;
            this.lStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lStatus.ForeColor = System.Drawing.Color.White;
            this.lStatus.Location = new System.Drawing.Point(11, 253);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(38, 13);
            this.lStatus.TabIndex = 13;
            this.lStatus.Text = "Ready";
            this.lStatus.Click += new System.EventHandler(this.lStatus_Click);
            // 
            // lDurationCounter
            // 
            this.lDurationCounter.AutoSize = true;
            this.lDurationCounter.BackColor = System.Drawing.Color.Transparent;
            this.lDurationCounter.ContextMenuStrip = this.cmsAbout;
            this.lDurationCounter.Cursor = System.Windows.Forms.Cursors.Default;
            this.lDurationCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDurationCounter.ForeColor = System.Drawing.Color.White;
            this.lDurationCounter.Location = new System.Drawing.Point(4, 17);
            this.lDurationCounter.Name = "lDurationCounter";
            this.lDurationCounter.Size = new System.Drawing.Size(440, 15);
            this.lDurationCounter.TabIndex = 14;
            this.lDurationCounter.Text = "0";
            this.lDurationCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lDurationCounter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.BackColor = System.Drawing.Color.Black;
            this.lTitle.ContextMenuStrip = this.cmsAbout;
            this.lTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.White;
            this.lTitle.Location = new System.Drawing.Point(11, 10);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(159, 17);
            this.lTitle.TabIndex = 16;
            this.lTitle.Text = "KH Random Player v1.0";
            this.lTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(377, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(59, 28);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(436, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShowPlaylist
            // 
            this.btnShowPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPlaylist.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowPlaylist.FlatAppearance.BorderSize = 0;
            this.btnShowPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShowPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPlaylist.ForeColor = System.Drawing.Color.Transparent;
            this.btnShowPlaylist.Location = new System.Drawing.Point(430, 247);
            this.btnShowPlaylist.Name = "btnShowPlaylist";
            this.btnShowPlaylist.Size = new System.Drawing.Size(56, 28);
            this.btnShowPlaylist.TabIndex = 8;
            this.btnShowPlaylist.UseVisualStyleBackColor = false;
            this.btnShowPlaylist.Click += new System.EventHandler(this.btnShowPlaylist_Click);
            // 
            // fetchAlbumCoverTimer
            // 
            this.fetchAlbumCoverTimer.Interval = 1000;
            this.fetchAlbumCoverTimer.Tick += new System.EventHandler(this.fetchAlbumCoverTimer_Tick);
            // 
            // lAudioCoverStatus
            // 
            this.lAudioCoverStatus.AutoSize = true;
            this.lAudioCoverStatus.BackColor = System.Drawing.Color.Transparent;
            this.lAudioCoverStatus.ContextMenuStrip = this.cmsAbout;
            this.lAudioCoverStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lAudioCoverStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAudioCoverStatus.ForeColor = System.Drawing.Color.White;
            this.lAudioCoverStatus.Location = new System.Drawing.Point(4, 33);
            this.lAudioCoverStatus.Name = "lAudioCoverStatus";
            this.lAudioCoverStatus.Size = new System.Drawing.Size(440, 17);
            this.lAudioCoverStatus.TabIndex = 20;
            this.lAudioCoverStatus.Text = "Cover ready";
            this.lAudioCoverStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lAudioCoverStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.ContextMenuStrip = this.cmsAbout;
            this.tableLayoutPanel6.Controls.Add(this.lAudioDurationStatus, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lAudioCoverStatus, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.lDurationCounter, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 283);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(448, 51);
            this.tableLayoutPanel6.TabIndex = 21;
            this.tableLayoutPanel6.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            this.tableLayoutPanel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Transparent;
            this.btnSettings.Location = new System.Drawing.Point(179, 247);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(70, 28);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // playSoundTrigger
            // 
            this.playSoundTrigger.Tick += new System.EventHandler(this.playSoundTrigger_Tick);
            // 
            // MediaPlayerSecret
            // 
            this.MediaPlayerSecret.Enabled = true;
            this.MediaPlayerSecret.Location = new System.Drawing.Point(453, 302);
            this.MediaPlayerSecret.Name = "MediaPlayerSecret";
            this.MediaPlayerSecret.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayerSecret.OcxState")));
            this.MediaPlayerSecret.Size = new System.Drawing.Size(10, 10);
            this.MediaPlayerSecret.TabIndex = 10;
            this.MediaPlayerSecret.Visible = false;
            // 
            // pBoxPlayerBack
            // 
            this.pBoxPlayerBack.BackColor = System.Drawing.Color.Transparent;
            this.pBoxPlayerBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBoxPlayerBack.ContextMenuStrip = this.cmsAbout;
            this.pBoxPlayerBack.Image = global::KHRandomPlayer.Properties.Resources.DefaultBack;
            this.pBoxPlayerBack.ImageLocation = "";
            this.pBoxPlayerBack.Location = new System.Drawing.Point(5, 33);
            this.pBoxPlayerBack.Name = "pBoxPlayerBack";
            this.pBoxPlayerBack.Size = new System.Drawing.Size(479, 213);
            this.pBoxPlayerBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxPlayerBack.TabIndex = 25;
            this.pBoxPlayerBack.TabStop = false;
            // 
            // pBoxSkinPlayer
            // 
            this.pBoxSkinPlayer.BackgroundImage = global::KHRandomPlayer.Properties.Resources.SkinPlayer;
            this.pBoxSkinPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxSkinPlayer.ContextMenuStrip = this.cmsAbout;
            this.pBoxSkinPlayer.Location = new System.Drawing.Point(3, 1);
            this.pBoxSkinPlayer.Name = "pBoxSkinPlayer";
            this.pBoxSkinPlayer.Size = new System.Drawing.Size(483, 276);
            this.pBoxSkinPlayer.TabIndex = 15;
            this.pBoxSkinPlayer.TabStop = false;
            this.pBoxSkinPlayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // KHRandomPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(975, 335);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.btnShowPlaylist);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.MediaPlayerSecret);
            this.Controls.Add(this.tlpPlaylist);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pBoxPlayerBack);
            this.Controls.Add(this.pBoxSkinPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "KHRandomPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.cmsAbout.ResumeLayout(false);
            this.cmsCurrentSong.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCover)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tlpPlaylist.ResumeLayout(false);
            this.tlpPlaylist.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerSecret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayerBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSkinPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lSongName;
        private System.Windows.Forms.Label lAlbumName;
        private System.Windows.Forms.Timer fetchMusicTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pBoxCover;
        private System.Windows.Forms.TableLayoutPanel tlpPlaylist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lListDuration3;
        private System.Windows.Forms.Label lListSong3;
        private System.Windows.Forms.Label lListDuration2;
        private System.Windows.Forms.Label lListSong2;
        private System.Windows.Forms.Label lListDuration1;
        private System.Windows.Forms.Label lListSong1;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayerSecret;
        private System.Windows.Forms.Label lListDuration10;
        private System.Windows.Forms.Label lListSong10;
        private System.Windows.Forms.Label lListDuration9;
        private System.Windows.Forms.Label lListSong9;
        private System.Windows.Forms.Label lListDuration8;
        private System.Windows.Forms.Label lListSong8;
        private System.Windows.Forms.Label lListDuration7;
        private System.Windows.Forms.Label lListSong7;
        private System.Windows.Forms.Label lListDuration6;
        private System.Windows.Forms.Label lListSong6;
        private System.Windows.Forms.Label lListDuration5;
        private System.Windows.Forms.Label lListSong5;
        private System.Windows.Forms.Label lListDuration4;
        private System.Windows.Forms.Label lListSong4;
        private System.Windows.Forms.Button btnNextSong;
        private System.Windows.Forms.Timer fetchDurationTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Label lAudioDurationStatus;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label lDurationCounter;
        private System.Windows.Forms.PictureBox pBoxSkinPlayer;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnShowPlaylist;
        private System.Windows.Forms.Label lTotalSongsFetched;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lListAlbum10;
        private System.Windows.Forms.Label lListAlbum9;
        private System.Windows.Forms.Label lListAlbum8;
        private System.Windows.Forms.Label lListAlbum7;
        private System.Windows.Forms.Label lListAlbum6;
        private System.Windows.Forms.Label lListAlbum5;
        private System.Windows.Forms.Label lListAlbum4;
        private System.Windows.Forms.Label lListAlbum3;
        private System.Windows.Forms.Label lListAlbum2;
        private System.Windows.Forms.Label lListAlbum1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer fetchAlbumCoverTimer;
        private System.Windows.Forms.Label lAudioCoverStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Timer playSoundTrigger;
        private System.Windows.Forms.ContextMenuStrip cmsCurrentSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveCover;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopySongName;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyAlbumName;
        private System.Windows.Forms.ToolStripMenuItem tsmiGoToAlbumSite;
        private System.Windows.Forms.PictureBox pBoxPlayerBack;
        private System.Windows.Forms.ContextMenuStrip cmsAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
    }
}

