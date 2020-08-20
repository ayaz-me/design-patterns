using AbstractFactory.Interface;

namespace AbstractFactory.Class
{
    public class BundesligaPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Robert Lewandowski";
        }
    }
}
