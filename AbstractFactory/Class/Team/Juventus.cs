using AbstractFactory.Interface;

namespace AbstractFactory.Class
{
    public class Juventus : ITeam
    {
        public string GetTeamColor()
        {
            return "Black and White";
        }
    }
}
