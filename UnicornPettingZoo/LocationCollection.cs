using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicornPettingZoo
{
    class LocationCollection
    {
        private List<Location> locations;

        public LocationCollection()
        {
            this.locations = new List<Location>();
        }

        public void AddLocation(string locationName)
        {
            Location newLocation = new Location(locationName);
            AddLocation(newLocation);
        }

        public void AddLocation(Location locationToAdd)
        {
            locations.Add(locationToAdd);
        }

        public Location GetLocation(string locationName)
        {
            return locations.FirstOrDefault(location => location.GetLocationName().Equals(locationName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
