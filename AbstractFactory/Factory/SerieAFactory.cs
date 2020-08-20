using AbstractFactory.Class;
using AbstractFactory.Interface;

namespace AbstractFactory.Factory
{
    public class SerieAFactory : IFootballFactory
    {
        public ITeam CreateTeam()
        {
            return new Juventus();
        }

        public IPlayer CreatePlayer()
        {
            return new SerieAPlayer();
        }
    }
}