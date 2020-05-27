using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {

            City Nashville = new City("Nashville")
            {
                cityMayor = "Mayor McCheese",
                cityYear = 1978,
            };
            City Nashvegas = new City("Nashvegas")
            {
                cityMayor = "Grimace",
                cityYear = 2020,
            };

            Console.WriteLine("These are my buildings!!");
            Building NSS = new Building("301 Plus Park")
            {
                Width = 200,
                Depth = 150,
                Stories = 5,
                Name = "NSS"
            };
            Building theOldNSSBuilding = new Building("500 Interstate Blvd");
            Building myHouse = new Building("Murfreesboro");

            theOldNSSBuilding.Width = 200;
            theOldNSSBuilding.Depth = 150;
            theOldNSSBuilding.Stories = 5;
            theOldNSSBuilding.Name = "The Old NSS Building";

            myHouse.Width = 200;
            myHouse.Depth = 150;
            myHouse.Stories = 5;
            myHouse.Name = "My House :)";

            NSS.Construct();
            theOldNSSBuilding.Construct();
            myHouse.Construct();

            NSS.Purchase("Jimmy JON");
            theOldNSSBuilding.Purchase("Blake");
            myHouse.Purchase("Some Rich Guy");

            Nashville.addBuilding(NSS);
            Nashville.addBuilding(theOldNSSBuilding);
            Nashvegas.addBuilding(myHouse);

            Console.WriteLine($"{Nashville.Name} has the following buildings");
            foreach (Building building in Nashville.Buildings)
            {
                Console.WriteLine($"{building.Name} located at {building.Address} ");
            }
            Console.WriteLine($"{Nashvegas.Name} has the following buildings");
            foreach (Building building in Nashvegas.Buildings)
            {
                Console.WriteLine($"{building.Name} located in {building.Address} the depth is {building.Depth}");
            }

        }
    }
}