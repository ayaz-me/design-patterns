using AbstractFactory.Interface;

namespace AbstractFactory.Class.LeaguePlayer
{
    public class SuperLigPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Burak Yılmaz";
        }
    }
}
