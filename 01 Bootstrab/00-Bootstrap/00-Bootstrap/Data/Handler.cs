
namespace _00_Bootstrap.Data
{
    public class Handler
    {
       
        public void SetData(Persoon Nieuwepersoon)
        {
            Persoon persoon = new Persoon();
            persoon.Naam = Nieuwepersoon.Naam;

        }
    }
}
