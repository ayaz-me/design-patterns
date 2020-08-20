using AbstractFactory.Interface;

namespace AbstractFactory.Class.Team
{
    public class Besiktas : ITeam
    {
        public string GetTeamColor()
        {
            return "Black and White";
        }
    }
}
