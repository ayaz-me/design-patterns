using AbstractFactory.Class;
using AbstractFactory.Interface;

namespace AbstractFactory.Factory
{
    public class BundesLigaFactory : IFootballFactory
    {
        public ITeam CreateTeam()
        {
            return new BorussiaDotmund();
        }

        public IPlayer CreatePlayer()
        {
            return new BundesligaPlayer();
        }
    }
}