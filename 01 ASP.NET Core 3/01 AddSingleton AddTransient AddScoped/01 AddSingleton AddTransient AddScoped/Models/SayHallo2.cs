using _01_AddSingleton_AddTransient_AddScoped.Interfaces;

namespace _01_AddSingleton_AddTransient_AddScoped.Models
{
    public class SayHallo2: ICanSayHallo2
    {
        private int nummer =1;
        private readonly ICanSayHallo SayHallo;
        public SayHallo2(ICanSayHallo sayHallo)
        {
            this.SayHallo = sayHallo;
        }
        public string Say2()
        {
            nummer++;
            return $"{this.SayHallo.SayHallo()} {nummer}";
        }
    }
}
