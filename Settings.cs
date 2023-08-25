using System;
using System.Windows.Forms;
using KHRandomPlayer.Classes;
using System.Text.Json;
using System.IO;

namespace KHRandomPlayer
{
    public partial class Settings : Form
    {
        public int Opt1 { get; set; }
        public double Opt2 { get; set; }
        public bool Opt3 { get; set; }

        public Settings(int opt1, double opt2, bool opt3)
        {
            InitializeComponent();
            numLimitSong.Value = opt1;
            numMinimumSong.Value = (decimal)opt2;
            cBoxCoverService.Checked = opt3;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SettingsModel settingsModel = new SettingsModel((int)numLimitSong.Value, (double)numMinimumSong.Value, cBoxCoverService.Checked);
            File.WriteAllText("Settings.json", JsonSerializer.Serialize(settingsModel));

            Opt1 = (int)numLimitSong.Value;
            Opt2 = (int)numMinimumSong.Value;
            Opt3 = cBoxCoverService.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
