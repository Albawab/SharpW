using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Editity_Framework.Models
{
    [Table("students")]
    class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int idRk { get; set; }

        [Column("studentGBA", Order = 2, TypeName = "char(20)")]
        public string naam { get; set; }

        public int adressId { get; set; }

        [ForeignKey(nameof(adressId))]
        public StudentAdress adress { get; set; }
    }

    class StudentAdress
    {
        public int Id { get; set; }
        public string Straat { get; set; }
        public int HuisNummer { get; set; }
        public string Postcode { get; set; }
        public string WoonPlats { get; set; }
    }
}