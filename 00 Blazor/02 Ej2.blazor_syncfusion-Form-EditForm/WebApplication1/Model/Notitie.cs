namespace HenE_Application.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Notitie
    {


        [Required]
        public Int32 Id { get; set; }

        [Required]
        public string Title { get; set; } = "r";

        public string Body { get; set; } = "b";

        [Required]
        public DateTime Datum { get; set; }
    }
}
