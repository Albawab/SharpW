using ApiInjection.Interfaces;

namespace ApiInjection.Models
{
    public class SayHelloInEnglish : IZegHallo
    {
        public string ZegHallo()
        {
            return "Hello";
        }
    }
}
