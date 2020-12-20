using System;

namespace FlyweightDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            IGalaxy star = GalaxyFactory.GetPlanetoryObject(PlanetaryType.Star);
            star.SetBrightness(10);
            star.SetPosition(20, 80);
            Console.WriteLine(star);


            IGalaxy planet = GalaxyFactory.GetPlanetoryObject(PlanetaryType.Planet);
            planet.SetBrightness(67);
            planet.SetPosition(120, 85);
            Console.WriteLine(planet);


            IGalaxy star2 = GalaxyFactory.GetPlanetoryObject(PlanetaryType.Star);
            star2.SetBrightness(65);
            star2.SetPosition(67, 23);
            Console.WriteLine(star2);

        }
    }
}
