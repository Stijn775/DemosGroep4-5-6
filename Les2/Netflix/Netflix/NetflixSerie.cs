namespace Netflix
{
    internal class NetflixSerie : IFormattable
    {
        public NetflixSerie(string title, int seasons, int episodes, DateTime releaseDate, string director, double rating)
        {
            Title = title;
            Seasons = seasons;
            Episodes = episodes;
            ReleaseDate = releaseDate;
            Director = director;
            Rating = rating;
        }

        public string Title { get; set; }
        public int Seasons { get; set; }
        public int Episodes { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public double Rating { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Seasons} seasons, {Episodes} episodes, Released on {ReleaseDate.ToShortDateString()}, Directed by {Director}, Rating: {Rating}";
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            switch (format)
            {
                case "s": return Title;
                case "n": return $"{Title} {Rating} {ReleaseDate}";
                case "e": return ToString();
                default:
                    throw new ArgumentException("Invalid Format");
            }
        }
    }
}
