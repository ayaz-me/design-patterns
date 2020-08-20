using AbstractFactory.Interface;

namespace AbstractFactory.Class
{
    public class LaLigaPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Benzema";
        }
    }
}