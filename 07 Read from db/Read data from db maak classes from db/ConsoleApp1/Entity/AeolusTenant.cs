namespace HenE.Aeolus.Beveiliging.Domein
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AeolusTenant
    {

        [Required]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        public string Prefix { get; set; }

        //public ICollection<AeolusRole> Roles { get; set; }
    }
}
