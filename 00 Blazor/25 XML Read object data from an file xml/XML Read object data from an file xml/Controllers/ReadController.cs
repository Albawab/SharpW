using System.IO;
using System.Xml.Serialization;
using XML_Read_object_data_from_an_file_xml.Data;

namespace XML_Read_object_data_from_an_file_xml.Controllers
{
    public class ReadController
    {

        public Student ReadXml()
        {
            XmlSerializer serial = new XmlSerializer(typeof(Student));
            StreamReader reader = new StreamReader(@"...\..\XMLFile.xml");
            Student student = (Student)serial.Deserialize(reader);
            return student;

        }

        public ClassSchool ReadClassSchool()
        {
            XmlSerializer serial = new XmlSerializer(typeof(ClassSchool));
            StreamReader reader = new StreamReader(@"...\..\XMLClassSchool.xml");
            ClassSchool classSchool = (ClassSchool)serial.Deserialize(reader);
            return classSchool;
        }
    }
}
