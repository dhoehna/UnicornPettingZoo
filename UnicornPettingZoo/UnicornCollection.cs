using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicornPettingZoo
{
    class UnicornCollection
    {
        private List<Unicorn> unicorns;

        public UnicornCollection()
        {
            this.unicorns = new List<Unicorn>();
        }

        public void AddUnicorn(string name, DateTime dateOfAppearance, int heigthInInches)
        {
            Unicorn unicornToAdd = new Unicorn(name, dateOfAppearance, heigthInInches);
            AddUnicorn(unicornToAdd);
        }

        public void AddUnicorn(Unicorn unicornToAdd)
        {
            unicorns.Add(unicornToAdd);
        }

        public Unicorn GetUnicorn(string unicornName)
        {
            return unicorns.FirstOrDefault(unicorn => unicorn.GetName().Equals(unicornName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
