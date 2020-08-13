using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Blazor;

namespace BlazorApp1
{
    public class SampleLocalizer : ISyncfusionStringLocalizer
    {

        public string Get(string key)
        {
            return this.Manager.GetString(key);
        }

        public System.Resources.ResourceManager Manager
        {
            get
            {

                return BlazorApp1.Resources.SyncfusionBlazorLocale.ResourceManager;
            }
        }
    }
}
