using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicornPettingZoo
{
    class Farm
    {
        private UnicornCollection unicorns;
        private LocationCollection locations;
        private Dictionary<Unicorn, Location> placesWhereTheUnicornsAre;


        public Farm(UnicornCollection unicorns, LocationCollection locations)
        {
            this.unicorns = unicorns;
            this.locations = locations;
            this.placesWhereTheUnicornsAre = new Dictionary<Unicorn, Location>();
        }

        public Farm(UnicornCollection unicorns, LocationCollection locations, Dictionary<Unicorn, Location> placesWhereTheUnicornsAre)
        {
            this.unicorns = unicorns;
            this.locations = locations;
            this.placesWhereTheUnicornsAre = placesWhereTheUnicornsAre;
        }

        public void UpdateUnicornLocation(Unicorn unicorn, Location locationWhereUnicornIsAt)
        {
            placesWhereTheUnicornsAre[unicorn] = locationWhereUnicornIsAt;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach(Unicorn unicorn in placesWhereTheUnicornsAre.Keys)
            {
                builder.Append(unicorn.GetName() + " ");
                builder.AppendLine(placesWhereTheUnicornsAre[unicorn].GetLocationName());
            }

            return builder.ToString();
        }
    }
}
