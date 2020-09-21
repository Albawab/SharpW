using _01_AddSingleton_AddTransient_AddScoped.Interfaces;

namespace _01_AddSingleton_AddTransient_AddScoped.Models
{
    public class SayHallo3 : ICanSayHallo3
    {
        private readonly ICanSayHallo sayHallo1;
        public SayHallo3(ICanSayHallo sayHallo)
        {
            this.sayHallo1 = sayHallo;
        }
        public string Say3()
        {
            return sayHallo1.SayHallo();
        }
    }
}
