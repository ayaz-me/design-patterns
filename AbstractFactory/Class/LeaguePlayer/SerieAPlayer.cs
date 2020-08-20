using AbstractFactory.Interface;

namespace AbstractFactory.Class
{
    public class SerieAPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Cristiano Ronaldo";
        }
    }
}