using AbstractFactory.Interface;

namespace AbstractFactory.Class
{
    public class BorussiaDotmund : ITeam
    {
        public string GetTeamColor()
        {
            return "Black and Yellow";
        }
    }
}
