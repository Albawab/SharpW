using _01_AddSingleton_AddTransient_AddScoped.Interfaces;

namespace _01_AddSingleton_AddTransient_AddScoped.Models
{
    public class ConvertToCM2 :IKanMeten2
    {
        private int nummer =1;
        private readonly IKanMeten meten;
        public ConvertToCM2(IKanMeten meten)
        {
            this.meten = meten;
        }
        public string ChangeFromMToCM2()
        {
            nummer++;
            return $"{meten.ChangeFromMToCM(1)} {nummer}";
        }
    }
}
