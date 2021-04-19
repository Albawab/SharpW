using System.Xml.Serialization;

namespace XML_Read_object_data_from_an_file_xml.Enum
{
    public enum Langte
    {
        [XmlEnum("150")] Kort = 150,
        Medium = 170,
        [XmlEnum("180")] Lang =180,
        XLang= 190,
        XXLang=195,
        XXXLang= 200,
    }
}
