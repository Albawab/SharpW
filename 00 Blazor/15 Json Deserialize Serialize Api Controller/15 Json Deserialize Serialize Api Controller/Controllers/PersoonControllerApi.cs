using Newtonsoft.Json;
using PersoonLibrary;
using PersoonLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace _15_Json_Deserialize_Serialize_Api_Controller.Controllers
{
    public class PersoonControllerApi : IControlPerson
    {

        public List<Persoon> persoonsList;
        public List<Persoon> GetPersoons()
        {
            this.GePersonenVanApi();
            Thread.Sleep(4000);
            return this.persoonsList;
        }

        public async void GePersonenVanApi()
        {
            HttpClient client = new HttpClient();

            var navigatorItemsJson = await client.GetStringAsync("https://localhost:5001/Persoon/1");

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            this.persoonsList = JsonConvert.DeserializeObject<List<Persoon>>(navigatorItemsJson, settings);
        }


    }
}
