using AbstractFactory.Class;
using AbstractFactory.Interface;

namespace AbstractFactory.Factory
{
    public class LaLigaFactory : IFootballFactory
    {
        public ITeam CreateTeam()
        {
            return new RealMadrid();
        }

        public IPlayer CreatePlayer()
        {
            return new LaLigaPlayer();
        }
    }
}