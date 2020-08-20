using AbstractFactory.Interface;

namespace AbstractFactory.Class
{
    public class RealMadrid : ITeam
    {
        public string GetTeamColor()
        {
            return "Blue and White";
        }
    }
}
