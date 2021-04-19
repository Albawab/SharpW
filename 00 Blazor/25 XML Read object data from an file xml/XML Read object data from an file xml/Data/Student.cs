using System;
using XML_Read_object_data_from_an_file_xml.Enum;

namespace XML_Read_object_data_from_an_file_xml.Data
{
    [Serializable]
    public class Student
    {
        public int Id{ get; set; }

        public string Naam{ get; set; }

        public Langte Langte { get; set; }

        public DateTime GD { get; set; }
    }
}
