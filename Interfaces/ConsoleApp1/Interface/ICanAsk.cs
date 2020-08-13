using System;
using System.Collections.Generic;
using System.Text;

namespace HenE.Interface
{
    public interface ICanAsk
    {


        string Ask(string question, ICanAnswer wieAntwoord);
    }
}
