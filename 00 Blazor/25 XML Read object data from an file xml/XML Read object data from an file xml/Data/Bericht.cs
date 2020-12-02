using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XML_Read_object_data_from_an_file_xml.Data
{
    using System;
    using System.ComponentModel;
    using System.Xml.Serialization;

    [Serializable]
    public class Bericht
    {
        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        public Header Header { get; set; }

    }
}
