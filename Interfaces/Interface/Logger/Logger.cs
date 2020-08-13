using System;
using System.Net;
using HenE.InterfaceCommunicate.Interfaces;

namespace HenE.Logger
{
    /// <summary>
    /// Take the informaion en send it to DateBase.
    /// </summary>
    public class Log : ILogger
    {

        /// <summary>
        /// This method take the information van de project en van de client.
        /// </summary>
        /// <param name="information">Het informatie die uit de server komt. </param>
        public void TakeInformation(string information)
        {
            SaveInformation(information, DateTime.Parse("10:10"), IPAddress.Parse("10.0.0.184"));
        }


        /// <summary>
        /// This method saved the information in the DataBase.
        /// </summary>
        /// <param name="info">Actie.</param>
        /// <param name="time">Tijd.</param>
        /// <param name="iPAddress">IpAddress van de client.</param>
        public void SaveInformation(string info, DateTime time, IPAddress iPAddress )
        {
            throw new NotImplementedException();
        }


    }
}
