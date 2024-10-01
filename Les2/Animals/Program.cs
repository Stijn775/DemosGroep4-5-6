namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konijn konijn = new Konijn();
            Eend eend = new Eend();
            GoudVis goudVis = new GoudVis();

            List<IGeluid> dierenMetGeluid = new List<IGeluid> { konijn, eend, goudVis };
            int randIndex = new Random().Next(2);
            dierenMetGeluid[randIndex].MaakGeluid();

            List<IZwem> zwemmers = new List<IZwem> { eend, goudVis };

            List<ILoop> lopers = new List<ILoop> { eend, konijn };

            foreach (IZwem zwemmer in zwemmers)
            {
                zwemmer.Zwem();
            }
        }
    }
}
