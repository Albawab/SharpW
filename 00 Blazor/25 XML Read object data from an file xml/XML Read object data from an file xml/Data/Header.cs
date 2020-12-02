using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_Read_object_data_from_an_file_xml.Data
{
    [Serializable]
    public class Header
    {
        /// <summary>
        /// Gets or sets the bericht code.
        /// </summary>
        public string BerichtCode { get; set; }

    }
}
