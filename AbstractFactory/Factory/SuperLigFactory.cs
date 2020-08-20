using AbstractFactory.Class.LeaguePlayer;
using AbstractFactory.Class.Team;
using AbstractFactory.Interface;

namespace AbstractFactory.Factory
{
    public class SuperLigFactory : IFootballFactory
    {
        public ITeam CreateTeam()
        {
            return new Besiktas();
        }

        public IPlayer CreatePlayer()
        {
            return new SuperLigPlayer();
        }
    }
}