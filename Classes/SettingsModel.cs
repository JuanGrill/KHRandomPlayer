namespace KHRandomPlayer.Classes
{
    internal class SettingsModel
    {
        public int S_LimitSongQueue { get; set; }
        public double S_MinimumSongLength { get; set; }
        public bool S_CoverServiceEnabled { get; set; }
        public string S_PlayerBackgroundRoute { get; set; }
        public bool S_AlwaysOnTop { get; set; }

        public SettingsModel() { }

        public SettingsModel(int limitSongQueue, double minimumSongLength, bool coverServiceEnabled, string playerBackgroundRoute, bool alwaysOnTop)
        {
            S_LimitSongQueue = limitSongQueue;
            S_MinimumSongLength = minimumSongLength;
            S_CoverServiceEnabled = coverServiceEnabled;
            S_PlayerBackgroundRoute = playerBackgroundRoute;
            S_AlwaysOnTop = alwaysOnTop;
        }
    }
}
