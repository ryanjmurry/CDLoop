namespace CDLoop.Models
{
    public class CD
    {
        private string _album;
        private string _artist;
        private int _price;

        public CD(string newAlbum, string newArtist, int newPrice)
        {
            _album = newAlbum;
            _artist = newArtist;
            _price = newPrice;
        }

        public string GetAlbum()
        {
            return _album;
        }

        public string GetArtist()
        {
            return _artist;
        }

        public int GetPrice()
        {
            return _price;
        }
    }
}
