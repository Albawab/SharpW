using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace HenE_Ej2.blazor_syncfusion.Data
{
    public class WachtwoordAttribute : ValidationAttribute
    {
        public ComplexiteitLevel Complexititeit { get; set; }

        /// <summary>
        /// Controleert of de value is geldig.
        /// </summary>
        /// <param name="ComplexiteitLevel">De value.</param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                // of is het dan true, dan moet je een required attr gaan gebruiken
                return true;
            }

            string wachtwoord = (string)value;

            /*    At least one upper case English letter, (?=.*?[A - Z])
                  At least one lower case English letter, (?=.*?[a - z])
                  At least one digit, (?=.*?[0 - 9])
                 At least one special character, (?=.*?[#?!@$%^&*-])
                   Minimum eight in length.{ 8,} (with the anchors)*/
            switch (this.Complexititeit)
            {
                case Data.ComplexiteitLevel.high:
                    this.ErrorMessage = "Het wachtwoord moet tenminste 8 karakters lang zijn.";
                    Regex high = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^\w\s]).{8,}$");
                    return high.IsMatch(wachtwoord);
                case Data.ComplexiteitLevel.normal:
                    this.ErrorMessage = "Het wachtwoord moet tenminste 5 karakters lang zijn.";
                    Regex normal = new Regex(@"^(?=.*?[a-z])(?=.*?[0-9]).{8,}$");
                    return normal.IsMatch(wachtwoord);
                case Data.ComplexiteitLevel.low:
                    this.ErrorMessage = "Het wachtwoord moet tenminste 5 karakters lang zijn.";
                    Regex low = new Regex(@"^(?=.*?[0-9]).{4,}$");
                    return low.IsMatch(wachtwoord);
                default:
                    return false;
            }
        }
    }
    public enum ComplexiteitLevel
    {
        IsDefined,
        high,
        normal,
        low
    }

}