namespace Netflix
{
    internal class NetflixSerie : IFormattable, IComparable<NetflixSerie>, IEquatable<NetflixSerie>
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

        public int CompareTo(NetflixSerie? other)
        {
            if(other == null)
            {
                throw new ArgumentException();
            }

            int ratingCompare = Rating.CompareTo(other.Rating);

            if (ratingCompare == 0)
            {
                int releaseDateCompare = ReleaseDate.CompareTo(other.ReleaseDate);

                if(releaseDateCompare == 0)
                {
                    return Title.CompareTo(other.Title);
                } else
                {
                    return releaseDateCompare;
                }
            }
            else
            {
                return ratingCompare;
            }


        }

        public bool Equals(NetflixSerie? other)
        {
            if(other == null)
            {
                new ArgumentException("Other kan niet null zijn");
            }

            return Title == other.Title && Seasons == other.Seasons && Episodes == other.Episodes && ReleaseDate == other.ReleaseDate && Director == other.Director && Rating == other.Rating;
        }

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
