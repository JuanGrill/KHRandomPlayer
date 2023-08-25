namespace KHRandomPlayer
{
    public class SongModel
    {
        public string Url { get; set; }
        public string SongName { get; set; }
        public string AlbumName { get; set; }
        public string Duration { get; set; }
        public string AlbumURL { get; set; }
        public string AlbumCoverURL { get; set; }

        public SongModel() { }
        public SongModel(string url, string songName, string albumName, string duration, string albumURL)
        {
            Url = url;
            SongName = songName;
            AlbumName = albumName;
            Duration = duration;
            AlbumURL = albumURL;
        }
    }
}
