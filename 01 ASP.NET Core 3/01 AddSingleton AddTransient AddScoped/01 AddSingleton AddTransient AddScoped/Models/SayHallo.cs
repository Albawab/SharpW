using _01_AddSingleton_AddTransient_AddScoped.Interfaces;

namespace _01_AddSingleton_AddTransient_AddScoped.Models
{
    public class SayHallo : ICanSayHallo
    {
        private int nummer = 1;
        string ICanSayHallo.SayHallo()
        {
            nummer++;
            return $"Ik ben kals 1 Import =>AddScoped =>( {nummer} )";
        }
    }
}
