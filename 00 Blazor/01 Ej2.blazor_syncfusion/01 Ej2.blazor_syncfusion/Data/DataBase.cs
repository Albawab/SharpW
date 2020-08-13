using System;
using System.Linq;

namespace _01_Ej2.blazor_syncfusion.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class DataBase
    {
        Geheuge geheuge = new Geheuge();
        public string Get()
        {
            return geheuge.Naam;
        }

        public void Save(string naam)
        {
            geheuge.Naam = naam;
        }
    }
}
