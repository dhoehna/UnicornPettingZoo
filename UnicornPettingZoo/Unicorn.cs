using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicornPettingZoo
{
    class Unicorn
    {
        private string name;
        private DateTime dateOfAppearance;
        private int heightInInches;

        public Unicorn()
        {

        }

        public Unicorn(string name, DateTime dateOfAppearance, int heightInInches)
        {
            this.name = name;
            this.dateOfAppearance = dateOfAppearance;
            this.heightInInches = heightInInches;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
