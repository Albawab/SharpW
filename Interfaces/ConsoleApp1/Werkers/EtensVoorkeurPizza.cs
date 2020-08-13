using HenE.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HenE.Werkers
{
    public class EtensVoorkeurPizza : IHebEenVoorkeurBijEten
    {
        public string MijnVoorkeurBijEten()
        {
            return "Pizza";
        }
    }
}
