using AbstractFactory.Interface;

namespace AbstractFactory.Client
{
    public class FootballWorld
    {
        private readonly ITeam _teamColor;
        private readonly IPlayer _teamScorer;

        public FootballWorld(IFootballFactory factory)
        {
            _teamColor = factory.CreateTeam();
            _teamScorer = factory.CreatePlayer();
        }

        public string GetFootballTeamColor()
        {
            return _teamColor.GetTeamColor();
        }

        public string GetTopScorer()
        {
            return _teamScorer.GetTopScorer();
        }
    }
}