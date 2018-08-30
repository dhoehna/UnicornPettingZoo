using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicornPettingZoo
{
    class Location
    {
        private string locationName;

        public Location(string locationName)
        {
            this.locationName = locationName;
        }

        public string GetLocationName()
        {
            return this.locationName;
        }
    }
}
