using Newtonsoft.Json;
using System;
using System.IO;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText(@"C:\Users\AbdulAbdulbawab\Desktop\Sharp\C-\Json\Json\TestJson.json");
            Student Abdul = JsonConvert.DeserializeObject<Student>(json);
            Console.WriteLine(Abdul.Name);
            

            string serializeObject = JsonConvert.SerializeObject(Abdul);
            Console.WriteLine(serializeObject);
            Console.ReadLine();
        }
    }
}
