using _00_Globomantics.Servises;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00_Globomantics.Controllers
{
    public class ConferenceController : Controller
    {

        public ConferenceController(IConferenceService conferenceService)
        {

        }
    }
}
