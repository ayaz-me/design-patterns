namespace AbstractFactory.Interface
{
    public interface IFootballFactory
    {
        ITeam CreateTeam();
        IPlayer CreatePlayer();
    }
}