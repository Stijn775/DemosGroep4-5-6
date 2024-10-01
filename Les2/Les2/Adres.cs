namespace Les2
{
    interface IAdres
    {
        string Straat { get; set; }
        string Huisnummer { get; set; }
        int Postcode { get; set; }
        string Gemeente { get; set; }
        string Land { get; set; }

        string? ToString();

        void StuurPost(string text);
    }

    internal class Adres: IAdres
    {
        public Adres(string straat, string huisnummer, int postcode, string gemeente, string land)
        {
            Straat = straat;
            Huisnummer = huisnummer;
            Postcode = postcode;
            Gemeente = gemeente;
            Land = land;
        }

        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public int Postcode { get; set; }
        public string Gemeente { get; set; }
        public string Land { get; set; }

        public override string? ToString()
        {
            return $"{Straat} {Huisnummer}, {Postcode} {Gemeente} {Land}";
        }

        public void StuurPost(string text)
        {
            // Doe hier iets met de post
        }
    }
}
