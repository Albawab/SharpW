using System.IO;
using System.Xml.Serialization;
using XML_Read_object_data_from_an_file_xml.Data;
using XML_Read_object_data_from_an_file_xml.Enum;

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
            XmlSerializer serial = new XmlSerializer(typeof(ClassSchool), CreateEnumOverrider());
            StreamReader reader = new StreamReader(@"...\..\XMLClassSchool.xml");
            ClassSchool classSchool = (ClassSchool)serial.Deserialize(reader);
            return classSchool;
        }
        
        public Bericht ReadBerichtHeader()
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "Bericht";
            xRoot.Namespace = "http://www.istandaarden.nl/ijw/3_0jw323/schema";
            xRoot.IsNullable = true;
            XmlSerializer serial = new XmlSerializer(typeof(Bericht), xRoot);
            StreamReader reader = new StreamReader(@"...\..\jw323.xml");
            Bericht bericht = (Bericht)serial.Deserialize(reader);
            return bericht;
        }


        public Person ReadInheritance()
        {

            XmlSerializer serial = new XmlSerializer(typeof(Baby));
            StreamReader reader = new StreamReader(@"...\..\Inheritance.xml");
            Baby bericht = (Baby)serial.Deserialize(reader);
            return bericht;
        }

        public XmlAttributeOverrides CreateEnumOverrider()
        {
            // Create the XmlOverrides and XmlAttributes objects.
            XmlAttributeOverrides xOver = new XmlAttributeOverrides();
            XmlAttributes xAttrs = new XmlAttributes();

            // Add an XmlEnumAttribute for the FoodType.Low enumeration.
            XmlEnumAttribute xEnum = new XmlEnumAttribute();
            xEnum.Name = "M";
            xAttrs.XmlEnum = xEnum;
            xOver.Add(typeof(Langte), "Medium", xAttrs);

            // Create the XmlSerializer, and return it.
            return xOver;
        }


    }
}
