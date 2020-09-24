using _01_AddSingleton_AddTransient_AddScoped.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_AddSingleton_AddTransient_AddScoped.Models
{
    public class SayHallo4 : ISayHallo4
    {
        ICanSayHallo canSayHallo1;
        public SayHallo4(ICanSayHallo canSayHallo)
        {
            this.canSayHallo1 = canSayHallo;
        }
        public string SayH4()
        {
            return canSayHallo1.SayHallo();
        }
    }
}
