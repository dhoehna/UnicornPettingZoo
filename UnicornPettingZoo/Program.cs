using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicornPettingZoo
{
    class Program
    {
        private static LocationCollection locations;
        private static UnicornCollection unicorns;
        private static Farm myFarm;
        static void Main(string[] args)
        {
                        /*
             *  Assume that the database is full
             *  Assume that the list of locations is filled in.
             */

            //List all unicorns in database nd their locations.  Since I am the head person I can tell people where to go.

            Initilize();
        }

        public static void Initilize()
        {
            InitilizeLocations();
            InitilizeUnicorns();
            InitilizeFarm();

            Console.WriteLine(myFarm);
        }

        public static void InitilizeLocations()
        {
            locations = new LocationCollection();

            Location location1 = new Location("Barn");
            locations.AddLocation(location1);

            Location location2 = new Location("Field");
            locations.AddLocation(location2);

            Location location3 = new Location("Pasture");
            locations.AddLocation(location3);
        }

        public static void InitilizeUnicorns()
        {
            unicorns = new UnicornCollection();

            Unicorn unicorn1 = new Unicorn("Darren Hoehna", new DateTime(1990, 02, 10), 200);
            unicorns.AddUnicorn(unicorn1);

            Unicorn unicorn2 = new Unicorn("Tierney Grim", new DateTime(1990, 05, 10), 190);
            unicorns.AddUnicorn(unicorn2);

        }

        public static void InitilizeFarm()
        {
            myFarm = new Farm(unicorns, locations);
            myFarm.UpdateUnicornLocation(unicorns.GetUnicorn("Darren Hoehna"), locations.GetLocation("Barn"));

            myFarm.UpdateUnicornLocation(unicorns.GetUnicorn("Tierney Grim"), locations.GetLocation("Field"));
        }
    }
}
