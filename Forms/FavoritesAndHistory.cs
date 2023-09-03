using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace KHRandomPlayer.Forms
{
    public partial class FavoritesAndHistory : Form
    {
        public int TabSelected { get; set; }

        public SongModel SongAddedToQueue { get; set; }

        public FavoritesAndHistory()
        {
            InitializeComponent();
        }

        private void FavoritesAndHistory_Load(object sender, System.EventArgs e)
        {
            tabFavoritesAndHistory.SelectedIndex = TabSelected;
            tabFavoritesAndHistory_SelectedIndexChanged(sender, e);
        }

        public bool AddToFavorites(string url, string songName, string albumName, string duration, string albumUrl, string albumCoverUrl)
        {
            DataGridViewRow row = null;

            try
            {
                row = dgFavorites.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["colFav_Url"].Value.ToString().Equals(url)).First();
            }
            catch
            {
                row = null;
            }

            if (row == null)
            {
                dgFavorites.Rows.Insert(0, url, songName, albumName, duration, albumUrl, albumCoverUrl);
                return true;
            }

            return false;
        }

        public void AddToHistory(string url, string songName, string albumName, string duration, string albumUrl, string albumCoverUrl)
        {
            dgHistory.Rows.Insert(0, url, songName, albumName, duration, albumUrl, albumCoverUrl);

            if (dgHistory.Rows.Count > 100)
            {
                dgHistory.Rows.RemoveAt(100);
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void tabFavoritesAndHistory_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tabFavoritesAndHistory.SelectedIndex == 0)
            {
                btnClear.Text = "Remove from favorites";
                if (dgFavorites.Rows.Count > 0 && dgFavorites.SelectedRows.Count > 0)
                {
                    btnClear.Enabled = true;
                    btnAddToQueue.Enabled = true;
                }
                else
                {
                    btnClear.Enabled = false;
                    btnAddToQueue.Enabled = false;
                }
            }
            else
            {
                btnClear.Text = "Clear history";
                if (dgHistory.Rows.Count > 0)
                {
                    btnClear.Enabled = true;
                }
                else
                {
                    btnClear.Enabled = false;
                }

                if (dgHistory.Rows.Count > 0 && dgHistory.SelectedRows.Count > 0)
                {
                    btnAddToQueue.Enabled = true;
                }
                else
                {
                    btnAddToQueue.Enabled = false;
                }
            }
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            if (btnClear.Text == "Remove from favorites")
            {
                dgFavorites.Rows.RemoveAt(dgFavorites.SelectedRows[0].Index);
            }
            else
            {
                dgHistory.Rows.Clear();
                btnClear.Enabled = false;
            }
        }

        private void btnAddToQueue_Click(object sender, System.EventArgs e)
        {
            DataGridViewCellCollection tempSong;
            if (tabFavoritesAndHistory.SelectedIndex == 0)
            {
                tempSong = dgFavorites.SelectedRows[0].Cells;
                SongAddedToQueue = new SongModel(tempSong["colFav_Url"].Value.ToString(), tempSong["colFav_SongName"].Value.ToString(), tempSong["colFav_AlbumName"].Value.ToString(), tempSong["colFav_Duration"].Value.ToString(), tempSong["colFav_AlbumURL"].Value.ToString(), tempSong["colFav_AlbumCoverUrl"].Value.ToString());
            }
            else
            {
                tempSong = dgHistory.SelectedRows[0].Cells;
                SongAddedToQueue = new SongModel(tempSong["colHis_Url"].Value.ToString(), tempSong["colHis_SongName"].Value.ToString(), tempSong["colHis_AlbumName"].Value.ToString(), tempSong["colHis_Duration"].Value.ToString(), tempSong["colHis_AlbumUrl"].Value.ToString(), tempSong["colHis_AlbumCoverUrl"].Value.ToString());
            }

            DialogResult = DialogResult.OK;
        }
    }
}
