using _01_AddSingleton_AddTransient_AddScoped.Interfaces;

namespace _01_AddSingleton_AddTransient_AddScoped.Models
{
    public class ConvertToCM : IKanMeten
    {
        private int nummer =1;
        public string ChangeFromMToCM(int meter)
        {
            nummer++;
            int cm = meter *100;
            return $"{cm} blijft zo altijd import => AddTransient =>({nummer})";
        }
    }
}
