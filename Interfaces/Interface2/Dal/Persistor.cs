using Interfaces;
using System;

namespace Dal
{
    public class Persistor : IDoeIets
    {
        private readonly ILog logger;

        public Persistor(ILog logger)
        {
            this.logger = logger;

        }

        public void DoeIets()
        {
            logger?.Log("dit gaat goed");
        }
    }
}
