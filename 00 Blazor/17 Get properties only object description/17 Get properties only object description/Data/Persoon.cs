using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace _17_Get_properties_only_object_description.Data
{
    public class Persoon
    {
        public int Id{ get; set; }

        [Description("De naam van een student")]
        public string name{ get; set; }
    }
}
