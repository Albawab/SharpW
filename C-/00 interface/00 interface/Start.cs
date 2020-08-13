using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_interface
{
    class Start : ICar, IDriver
    {
        public int speed()
        {
            Int16 s = 8;
            Int16 l = 8;
            return 8 + 8;
        }

        string IDriver.Naam()
        {
            return "Abdul";
        }

        int IDriver.oud()
        {
            return 32;
        }

        string ICar.Naam()
        {
            return "auto";
        }

        public int oud()
        {
            return 8;
        }

    }
}
