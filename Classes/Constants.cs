namespace KHRandomPlayer
{
    public static class Constants
    {
        public class Matches
        {
            public const string songUrlFirstMatch = "<audio id=\"audio\" controls preload=\"auto\" src=\"";
            public const string songUrlSecondMatch = "autoplay>";
            public const string songNameFirstMatch = "Song name: <b>";
            public const string songNameSecondMatch = "</b></p>";
            public const string songAlbumFirstMatch = "Album name: <b>";
            public const string songAlbumSecondMatch = "</b><br>";
            public const string songAlbumUrlFirstMatch = "Go back to the album - <b><a href=\"";
            public const string songAlbumUrlSecondMatch = "\">";
            public const string songAlbumCoverFirstMatch = "albumImage";
            public const string songAlbumCoverSecondMatch = "\" target";
        }

        public class Urls
        {
            public const string baseUrl = "https://downloads.khinsider.com";
            public const string randomDirectory = baseUrl + "/random-song";
        }

        public class FileNames
        {
            public const string saveFileName = "Settings.json";
        }

        public class Configutation
        {
            public const int settingsForm_numLimitSong_minValue = 5;
            public const int settingsForm_numLimitSong_maxValue = 99;
            public const int settingsForm_numMinimumSong_minValue = 0;
            public const int settingsForm_numMinimumSong_maxValue = 99999;
        }
    }
}
