using AbstractFactory.Client;
using AbstractFactory.Factory;
using AbstractFactory.Interface;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFootballFactory germany = new BundesLigaFactory();

            IFootballFactory spain = new LaLigaFactory();

            IFootballFactory italy = new SerieAFactory();

            IFootballFactory turkey = new SuperLigFactory();

            FootballWorld footballWorld = new FootballWorld(turkey);

            Console.WriteLine(footballWorld.GetFootballTeamColor());

            Console.WriteLine(footballWorld.GetTopScorer());


            Console.ReadKey();
        }
    }
}