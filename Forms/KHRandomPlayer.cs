using KHRandomPlayer.Classes;
using KHRandomPlayer.Forms;
using KHRandomPlayer.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace KHRandomPlayer
{
    public partial class KHRandomPlayer : Form
    {
        private List<SongModel> bufferPlaylist = new List<SongModel>();
        private List<Label> listSongLabelsPlaylist = new List<Label>();
        private List<Label> listSongDurationLabelsPlaylist = new List<Label>();
        private List<Label> listSongAlbumLabelsPlaylist = new List<Label>();
        private WebClient client;
        private WebClient client2;

        private int numLimitSongQueue;
        private double minSongLength;
        private bool coverServiceEnabled;
        private bool alwaysOnTop;

        private SettingsModel settingsModel;

        private int durationCounter = 0;
        private SongModel tempSongDuration = new SongModel();
        private SongModel tempSongCover = new SongModel();

        private FavoritesAndHistory favAndHistForm = new FavoritesAndHistory();
        private Settings settingsForm;
        private About aboutForm;

        public KHRandomPlayer()
        {
            InitializeComponent();

            client = new WebClient();
            client.Headers.Add("content-type", "text/html");

            client2 = new WebClient();
            client2.Headers.Add("content-type", "text/html");

            lStatus.Text = "Ready";
            lAudioDurationStatus.Text = "Duration ready";
            lAudioCoverStatus.Text = "Cover ready";

            MediaPlayerSecret.settings.mute = true;

            listSongLabelsPlaylist.Add(lListSong1);
            listSongLabelsPlaylist.Add(lListSong2);
            listSongLabelsPlaylist.Add(lListSong3);
            listSongLabelsPlaylist.Add(lListSong4);
            listSongLabelsPlaylist.Add(lListSong5);
            listSongLabelsPlaylist.Add(lListSong6);
            listSongLabelsPlaylist.Add(lListSong7);
            listSongLabelsPlaylist.Add(lListSong8);
            listSongLabelsPlaylist.Add(lListSong9);
            listSongLabelsPlaylist.Add(lListSong10);

            listSongDurationLabelsPlaylist.Add(lListDuration1);
            listSongDurationLabelsPlaylist.Add(lListDuration2);
            listSongDurationLabelsPlaylist.Add(lListDuration3);
            listSongDurationLabelsPlaylist.Add(lListDuration4);
            listSongDurationLabelsPlaylist.Add(lListDuration5);
            listSongDurationLabelsPlaylist.Add(lListDuration6);
            listSongDurationLabelsPlaylist.Add(lListDuration7);
            listSongDurationLabelsPlaylist.Add(lListDuration8);
            listSongDurationLabelsPlaylist.Add(lListDuration9);
            listSongDurationLabelsPlaylist.Add(lListDuration10);

            listSongAlbumLabelsPlaylist.Add(lListAlbum1);
            listSongAlbumLabelsPlaylist.Add(lListAlbum2);
            listSongAlbumLabelsPlaylist.Add(lListAlbum3);
            listSongAlbumLabelsPlaylist.Add(lListAlbum4);
            listSongAlbumLabelsPlaylist.Add(lListAlbum5);
            listSongAlbumLabelsPlaylist.Add(lListAlbum6);
            listSongAlbumLabelsPlaylist.Add(lListAlbum7);
            listSongAlbumLabelsPlaylist.Add(lListAlbum8);
            listSongAlbumLabelsPlaylist.Add(lListAlbum9);
            listSongAlbumLabelsPlaylist.Add(lListAlbum10);

            //Transparent form
            this.BackColor = Color.DarkBlue;
            this.TransparencyKey = Color.DarkBlue;
            this.Size = new Size(500, 280);

            //Transparent window buttons
            btnClose.Parent = pBoxSkinPlayer;
            btnMinimize.Parent = pBoxSkinPlayer;
            btnShowPlaylist.Parent = pBoxSkinPlayer;
            btnSettings.Parent = pBoxSkinPlayer;
            btnToggleMiniplayer.Parent = pBoxSkinPlayer;
            btnFavorites.Parent = pBoxSkinPlayer;
            btnHistory.Parent = pBoxSkinPlayer;
            tlpMainPlayer.Parent = pBoxPlayerBack;
            tlpMainPlayer.Location = new Point(tlpMainPlayer.Location.X - pBoxPlayerBack.Location.X, tlpMainPlayer.Location.Y - pBoxPlayerBack.Location.Y);

            //Load settings
            if (File.Exists(Constants.FileNames.saveFileName))
            {
                settingsModel = JsonSerializer.Deserialize<SettingsModel>(File.ReadAllText(Constants.FileNames.saveFileName));

                if (settingsModel.S_MinimumSongLength < Constants.Configutation.settingsForm_numMinimumSong_minValue)
                {
                    settingsModel.S_MinimumSongLength = Constants.Configutation.settingsForm_numMinimumSong_minValue;
                }
                else if (settingsModel.S_MinimumSongLength > Constants.Configutation.settingsForm_numMinimumSong_maxValue)
                {
                    settingsModel.S_MinimumSongLength = Constants.Configutation.settingsForm_numMinimumSong_maxValue;
                }

                if (settingsModel.S_LimitSongQueue < Constants.Configutation.settingsForm_numLimitSong_minValue)
                {
                    settingsModel.S_LimitSongQueue = Constants.Configutation.settingsForm_numLimitSong_minValue;
                }
                else if (settingsModel.S_LimitSongQueue > Constants.Configutation.settingsForm_numLimitSong_maxValue)
                {
                    settingsModel.S_LimitSongQueue = Constants.Configutation.settingsForm_numLimitSong_maxValue;
                }
            }
            else
            {
                settingsModel = new SettingsModel(20, 30, true, "", false);
                File.WriteAllText(Constants.FileNames.saveFileName, JsonSerializer.Serialize(settingsModel));
            }

            numLimitSongQueue = settingsModel.S_LimitSongQueue;
            minSongLength = settingsModel.S_MinimumSongLength;
            coverServiceEnabled = settingsModel.S_CoverServiceEnabled;
            alwaysOnTop = settingsModel.S_AlwaysOnTop;

            settingsForm = new Settings(numLimitSongQueue, minSongLength, coverServiceEnabled, pBoxPlayerBack.ImageLocation, alwaysOnTop);
            aboutForm = new About();

            if (settingsModel.S_PlayerBackgroundRoute != "" && File.Exists(settingsModel.S_PlayerBackgroundRoute))
            {
                pBoxPlayerBack.ImageLocation = settingsModel.S_PlayerBackgroundRoute;
            }
            else
            {
                pBoxPlayerBack.Image = Resources.DefaultBack;
            }

            TopMost = alwaysOnTop;
            settingsForm.TopMost = alwaysOnTop;
            aboutForm.TopMost = alwaysOnTop;
            favAndHistForm.TopMost = alwaysOnTop;
        }

        private void StartFetch(object sender, EventArgs e)
        {
            if (btnFetch.Text == "Fetch")
            {
                btnFetch.Text = "Stop";
                fetchMusicTimer.Enabled = true;
                fetchDurationTimer.Enabled = true;

                if (coverServiceEnabled)
                {
                    fetchAlbumCoverTimer.Enabled = true;
                }
            }

            else if (btnFetch.Text == "Stop")
            {
                btnFetch.Text = "Fetch";
                fetchMusicTimer.Enabled = false;
                fetchDurationTimer.Enabled = false;
                fetchAlbumCoverTimer.Enabled = false;
            }
        }

        private async Task FetchMusic()
        {
            try
            {
                //Get HTML site
                lStatus.Text = "Fetching song...";
                Stream data = await client.OpenReadTaskAsync(new Uri(Constants.Urls.randomDirectory, UriKind.Absolute));
                StreamReader reader = new StreamReader(data);
                string htmlPage = await reader.ReadToEndAsync();
                client.Dispose();

                //Get song URL
                string url = htmlPage.Substring(htmlPage.IndexOf(Constants.Matches.songUrlFirstMatch) + Constants.Matches.songUrlFirstMatch.Length, htmlPage.IndexOf(Constants.Matches.songUrlSecondMatch) - 3 - htmlPage.IndexOf(Constants.Matches.songUrlFirstMatch) - Constants.Matches.songUrlFirstMatch.Length);

                //Get song name
                string songFirstCut = htmlPage.Substring(htmlPage.IndexOf(Constants.Matches.songNameFirstMatch) + Constants.Matches.songNameFirstMatch.Length);
                string songName = HttpUtility.HtmlDecode(songFirstCut.Substring(0, songFirstCut.IndexOf(Constants.Matches.songNameSecondMatch) - songFirstCut.IndexOf(Constants.Matches.songNameFirstMatch) - 1));
                if (songName.Trim() == "") { songName = "[Unknown]"; }

                //Get album name
                string albumfirstCut = htmlPage.Substring(htmlPage.IndexOf(Constants.Matches.songAlbumFirstMatch) + Constants.Matches.songAlbumFirstMatch.Length);
                string albumName = HttpUtility.HtmlDecode(albumfirstCut.Substring(0, albumfirstCut.IndexOf(Constants.Matches.songAlbumSecondMatch) - albumfirstCut.IndexOf(Constants.Matches.songAlbumFirstMatch) - 1));

                //Get album URL (For cover)
                string albumUrlfirstCut = htmlPage.Substring(htmlPage.IndexOf(Constants.Matches.songAlbumUrlFirstMatch) + Constants.Matches.songAlbumUrlFirstMatch.Length);
                string albumUrl = HttpUtility.HtmlDecode(albumUrlfirstCut.Substring(0, albumUrlfirstCut.IndexOf(Constants.Matches.songAlbumUrlSecondMatch) - albumUrlfirstCut.IndexOf(Constants.Matches.songAlbumUrlFirstMatch) - 1));

                SongModel tempSong = new SongModel(url, songName, albumName, "Loading...", Constants.Urls.baseUrl + albumUrl);
                bufferPlaylist.Add(tempSong);

                lStatus.Text = "Ready";
            }
            catch (Exception)
            {
                lStatus.Text = "Error in server. Retrying...";
            }
        }

        private void PlayMusic()
        {
            MediaPlayer.URL = bufferPlaylist[0].Url;
            MediaPlayer.Ctlcontrols.play();
            MediaPlayer.settings.autoStart = true;
            MediaPlayer.settings.setMode("loop", false);

            lSongName.Text = bufferPlaylist[0].SongName;
            lAlbumName.Text = bufferPlaylist[0].AlbumName;

            tsmiCopySongName.Enabled = true;
            tsmiCopyAlbumName.Enabled = true;
            tsmiGoToAlbumSite.Enabled = true;

            if (bufferPlaylist[0].AlbumCoverURL != "No cover" && coverServiceEnabled)
            {
                tsmiSaveCover.Enabled = true;
                pBoxCover.ImageLocation = bufferPlaylist[0].AlbumCoverURL;
            }
            else
            {
                tsmiSaveCover.Enabled = false;
                pBoxCover.ImageLocation = "";
            }

            btnDownload.Enabled = true;
            btnAddFavorites.Enabled = true;
        }

        private void PlayNextSong()
        {
            //If there's one song left in queue, don't continue to the next song
            if (bufferPlaylist.Count > 1)
            {
                //Save to history before remove it
                SongModel tempSongModel = bufferPlaylist[0];
                favAndHistForm.AddToHistory(tempSongModel.Url, tempSongModel.SongName, tempSongModel.AlbumName, tempSongModel.Duration, tempSongModel.AlbumURL, tempSongModel.AlbumCoverURL);

                bufferPlaylist.RemoveAt(0);
                UpdateTable();

                btnAddFavorites.Text = "Add to favorites";

                //Disable Next song button
                if (bufferPlaylist.Count < 2 || bufferPlaylist[1] == null || bufferPlaylist[1].Duration == "Loading...")
                {
                    btnNextSong.Enabled = false;
                }

                PlayMusic();
            }
        }

        /// <summary>
        /// TIMERS
        /// </summary>
        private async void fetchMusictimer_Tick(object sender, EventArgs e)
        {
            if (lStatus.Text != "Fetching song..." && bufferPlaylist.Count < numLimitSongQueue)
            {
                await FetchMusic();
            }
        }

        private void fetchDurationTimer_Tick(object sender, EventArgs e)
        {
            if (lAudioDurationStatus.Text == "Duration ready")
            {
                tempSongDuration = bufferPlaylist.Find(x => x.SongName != "" && x.Duration == "Loading...");

                if (tempSongDuration != null)
                {
                    lAudioDurationStatus.Text = "Song found, getting duration...";

                    MediaPlayerSecret.URL = tempSongDuration.Url;
                    MediaPlayerSecret.Ctlcontrols.play();
                }
            }

            if (lAudioDurationStatus.Text == "Song found, getting duration...")
            {
                durationCounter++;
                lDurationCounter.Text = durationCounter.ToString();
                if (MediaPlayerSecret.playState == WMPLib.WMPPlayState.wmppsPlaying ||
                    MediaPlayerSecret.playState == WMPLib.WMPPlayState.wmppsMediaEnded ||
                    MediaPlayerSecret.playState == WMPLib.WMPPlayState.wmppsStopped ||
                    MediaPlayerSecret.playState == WMPLib.WMPPlayState.wmppsReady)
                //if (durationCounter > 2)
                {
                    double duration = MediaPlayerSecret.Ctlcontrols.currentItem.duration;

                    if (duration < minSongLength)
                    {
                        lDurationCounter.Text = "Song doesn't meet with minimum length: " + duration + ". Deleted at " + bufferPlaylist.IndexOf(tempSongDuration);
                        bufferPlaylist.RemoveAt(bufferPlaylist.IndexOf(tempSongDuration));
                    }
                    else
                    {
                        bufferPlaylist[bufferPlaylist.IndexOf(tempSongDuration)].Duration = MediaPlayerSecret.Ctlcontrols.currentItem.durationString;
                        lDurationCounter.Text = "";

                        //First song of the day
                        if (MediaPlayer.URL == "")
                        {
                            PlayMusic();
                        }
                    }

                    durationCounter = 0;
                    lAudioDurationStatus.Text = "Duration ready";
                    UpdateTable();
                }
            }

            if (bufferPlaylist.Count > 1 && bufferPlaylist[1] != null && bufferPlaylist[1].Duration != "Loading...")
            {
                btnNextSong.Enabled = true;
            }
        }

        private async void fetchAlbumCoverTimer_Tick(object sender, EventArgs e)
        {
            if (lAudioCoverStatus.Text == "Cover ready" || lAudioCoverStatus.Text == "Error in server for cover. Retrying...")
            {
                tempSongCover = bufferPlaylist.Find(x => x.AlbumURL != "" && x.AlbumCoverURL == null && x.Duration != "Loading...");

                if (tempSongCover != null)
                {
                    try
                    {
                        lAudioCoverStatus.Text = "Song found, fetching cover...";
                        Stream data2 = await client2.OpenReadTaskAsync(new Uri(tempSongCover.AlbumURL, UriKind.Absolute));
                        StreamReader reader2 = new StreamReader(data2);
                        string htmlPage2 = await reader2.ReadToEndAsync();
                        client2.Dispose();

                        //Get album URL (For cover)
                        string albumCoverfirstCut = htmlPage2.Substring(htmlPage2.IndexOf(Constants.Matches.songAlbumCoverFirstMatch) + Constants.Matches.songAlbumCoverFirstMatch.Length + 25);

                        //Continue if cover exists
                        if (albumCoverfirstCut != null)
                        {
                            string albumCover = HttpUtility.HtmlDecode(albumCoverfirstCut.Substring(0, albumCoverfirstCut.IndexOf(Constants.Matches.songAlbumCoverSecondMatch)));

                            //Save cover only if exists
                            if (albumCover.StartsWith("http"))
                            {
                                bufferPlaylist[bufferPlaylist.IndexOf(tempSongCover)].AlbumCoverURL = albumCover;
                                if (MediaPlayer.URL == bufferPlaylist[bufferPlaylist.IndexOf(tempSongCover)].Url)
                                {
                                    pBoxCover.ImageLocation = albumCover;
                                }
                            }
                            else
                            {
                                bufferPlaylist[bufferPlaylist.IndexOf(tempSongCover)].AlbumCoverURL = "No cover";
                            }
                        }
                        else
                        {
                            bufferPlaylist[bufferPlaylist.IndexOf(tempSongCover)].AlbumCoverURL = "No cover";
                        }

                        lAudioCoverStatus.Text = "Cover ready";
                    }
                    catch (Exception)
                    {
                        lAudioCoverStatus.Text = "Error in server for cover. Retrying...";
                    }
                }
            }
        }

        private void playSoundTrigger_Tick(object sender, EventArgs e)
        {
            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsReady)
            {
                MediaPlayer.Ctlcontrols.play();
                playSoundTrigger.Enabled = false;
            }
        }

        private void UpdateTable()
        {
            lTotalSongsFetched.Text = "Songs fetched: " + bufferPlaylist.Count;

            int counter = 0;
            for (int i = 0; i < bufferPlaylist.Count; i++)
            {
                if (i > 9)
                {
                    return;
                }
                listSongLabelsPlaylist[i].Text = bufferPlaylist[i].SongName;
                listSongAlbumLabelsPlaylist[i].Text = bufferPlaylist[i].AlbumName;
                listSongDurationLabelsPlaylist[i].Text = bufferPlaylist[i].Duration;
                counter++;
            }

            for (int i = counter; i < listSongLabelsPlaylist.Count; i++)
            {
                listSongLabelsPlaylist[i].Text = "";
                listSongAlbumLabelsPlaylist[i].Text = "";
                listSongDurationLabelsPlaylist[i].Text = "";
            }
        }

        private void MediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                PlayNextSong();
                playSoundTrigger.Enabled = true;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string tempUrl = MediaPlayer.URL;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Audio files | *.mp3";
            saveFileDialog1.FileName = lSongName.Text;
            saveFileDialog1.DefaultExt = ".mp3";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(tempUrl, saveFileDialog1.FileName);
            }
        }

        private void btnNextSong_Click(object sender, EventArgs e)
        {
            PlayNextSong();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowPlaylist_Click(object sender, EventArgs e)
        {
            if (this.Size.Width > 900)
            {
                this.Size = new Size(500, this.Size.Height);
            }
            else
            {
                this.Size = new Size(975, this.Size.Height);
            }
        }

        private void lStatus_Click(object sender, EventArgs e)
        {
            if (this.Size.Height > 300)
            {
                this.Size = new Size(this.Width, 280);
            }
            else
            {
                this.Size = new Size(this.Width, 335);
            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, tlpPlaylist.ClientRectangle, Color.DarkCyan, 2, ButtonBorderStyle.Solid, Color.DarkCyan, 2, ButtonBorderStyle.Solid, Color.DarkCyan, 2, ButtonBorderStyle.Solid, Color.DarkCyan, 2, ButtonBorderStyle.Solid);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsForm.Opt1 = numLimitSongQueue;
            settingsForm.Opt2 = minSongLength;
            settingsForm.Opt3 = coverServiceEnabled;
            settingsForm.Opt4 = pBoxPlayerBack.ImageLocation;
            settingsForm.Opt5 = alwaysOnTop; 

            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                numLimitSongQueue = settingsForm.Opt1;
                minSongLength = settingsForm.Opt2;
                coverServiceEnabled = settingsForm.Opt3;

                if (settingsForm.Opt4 != "")
                {
                    pBoxPlayerBack.ImageLocation = settingsForm.Opt4;
                }

                fetchAlbumCoverTimer.Enabled = coverServiceEnabled;

                TopMost = settingsForm.Opt5;
                settingsForm.TopMost = settingsForm.Opt5;
                aboutForm.TopMost = settingsForm.Opt5;
                favAndHistForm.TopMost = settingsForm.Opt5;
            }
        }

        private void tsmiCopySongName_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lSongName.Text);
        }

        private void tsmiCopyAlbumName_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lAlbumName.Text);
        }

        private void tsmiSaveCover_Click(object sender, EventArgs e)
        {
            string tempUrl = bufferPlaylist[0].AlbumCoverURL;

            string ext = Path.GetExtension(tempUrl);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = lSongName.Text + " (Cover)" + ext;
            saveFileDialog1.Filter = "Image files | *" + ext;
            saveFileDialog1.DefaultExt = ext;
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(tempUrl, saveFileDialog1.FileName);
            }
        }

        private void tsmiGoToAlbumSite_Click(object sender, EventArgs e)
        {
            Process.Start(bufferPlaylist[0].AlbumURL);
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            aboutForm.ShowDialog();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MoveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private bool miniPlayerEnabled = false;

        private void btnToggleMiniplayer_Click(object sender, EventArgs e)
        {
            if (!miniPlayerEnabled)
            {
                pBoxSkinPlayer.BackgroundImage = Resources.KHPlayerSkin_Mini_Blue;
                lTitle.Visible = false;
                lStatus.Visible = false;
                tlpMainPlayer.Size = new Size(220, tlpMainPlayer.Size.Height);
                pBoxPlayerBack.Size = new Size(239, pBoxPlayerBack.Size.Height);
                this.Size = new Size(250, 280);
                btnAddFavorites.Text = "Fav";
                btnDownload.Text = "Dl";
                btnNextSong.Text = "Next";
                tlpCoverAndSongName.ColumnStyles[0].Width = 0;
                pBoxCover.Visible = false;

                btnClose.Location = new Point(194, btnClose.Location.Y);
                btnMinimize.Location = new Point(135, btnMinimize.Location.Y);
                btnSettings.Location = new Point(-8, btnSettings.Location.Y);
                btnFavorites.Location = new Point(40, btnFavorites.Location.Y);
                btnHistory.Location = new Point(78, btnHistory.Location.Y);

                miniPlayerEnabled = !miniPlayerEnabled;
            }
            else
            {
                pBoxSkinPlayer.BackgroundImage = Resources.KHPlayerSkin_Normal_Blue;
                lTitle.Visible = true;
                lStatus.Visible = true;
                tlpMainPlayer.Size = new Size(461, tlpMainPlayer.Size.Height);
                pBoxPlayerBack.Size = new Size(479, pBoxPlayerBack.Size.Height);
                this.Size = new Size(500, 280);
                btnAddFavorites.Text = "Add to favorites";
                btnDownload.Text = "Download";
                btnNextSong.Text = "Next song";
                tlpCoverAndSongName.ColumnStyles[0].Width = 99;
                pBoxCover.Visible = true;

                btnClose.Location = new Point(436, btnClose.Location.Y);
                btnMinimize.Location = new Point(377, btnMinimize.Location.Y);
                btnSettings.Location = new Point(271, btnSettings.Location.Y);
                btnFavorites.Location = new Point(316, btnFavorites.Location.Y);
                btnHistory.Location = new Point(357, btnHistory.Location.Y);

                miniPlayerEnabled = !miniPlayerEnabled;
            }
        }

        private void btnAddFavorites_Click(object sender, EventArgs e)
        {
            SongModel tempSongModel = bufferPlaylist[0];
            if (favAndHistForm.AddToFavorites(tempSongModel.Url, tempSongModel.SongName, tempSongModel.AlbumName, tempSongModel.Duration, tempSongModel.AlbumURL, tempSongModel.AlbumCoverURL))
            {
                btnAddFavorites.Text = "Added to favorites!";
            }
            else
            {
                btnAddFavorites.Text = "Already on favorites!";
            }
        }

        private void btnFavorites_Click(object sender, EventArgs e)
        {
            favAndHistForm.TabSelected = 0;

            if (favAndHistForm.ShowDialog() == DialogResult.OK)
            {
                bufferPlaylist.Insert(0, favAndHistForm.SongAddedToQueue);
                PlayMusic();
                UpdateTable();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            favAndHistForm.TabSelected = 1;

            if (favAndHistForm.ShowDialog() == DialogResult.OK)
            {
                bufferPlaylist.Insert(0, favAndHistForm.SongAddedToQueue);
                PlayMusic();
                UpdateTable();
            }
        }
    }
}
