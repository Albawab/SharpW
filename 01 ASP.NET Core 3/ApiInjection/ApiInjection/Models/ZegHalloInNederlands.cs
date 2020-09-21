using ApiInjection.Interfaces;

namespace ApiInjection.Models
{
    public class ZegHalloInNederlands : IZegHallo
    {
        int number = 0;

        public ZegHalloInNederlands()
        {
        }

        public string ZegHallo()
        {
            number ++;
            return $"Hallo {number}";
        }
    }
}
