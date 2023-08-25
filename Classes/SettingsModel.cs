namespace KHRandomPlayer.Classes
{
    internal class SettingsModel
    {
        public int S_LimitSongQueue { get; set; }
        public double S_MinimumSongLength { get; set; }
        public bool S_CoverServiceEnabled { get; set; }
        public SettingsModel() { }

        public SettingsModel(int limitSongQueue, double minimumSongLength, bool coverServiceEnabled)
        {
            S_LimitSongQueue = limitSongQueue;
            S_MinimumSongLength = minimumSongLength;
            S_CoverServiceEnabled = coverServiceEnabled;
        }
    }
}
