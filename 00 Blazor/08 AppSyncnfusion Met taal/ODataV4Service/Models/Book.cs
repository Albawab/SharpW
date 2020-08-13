using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ODataV4Service.Models
{ 

    public class Book
    {
        private int v1;
        private Guid newGuid;
        private string v2;
        private string v3;
        private string v4;
        private decimal v5;

        public Book(int Id, string ISBN, string Title, string Author, decimal Price)
        {
            this.Id = Id;
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
            this.Price = Price;
        }

        [Key]
     
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public BranchType Branch { get; set; }
        public Region Regime { get; set; }
        public Guid RelatedOrderId { get; set; }
        public virtual Book RelatedOrder { get; set; }
    }
    public enum BranchType
    {
        //[EnumMember(Value ="Dirección")]
        [Display(Name = "Dirección")]
        Direccion,
        //[EnumMember(Value = "Representación")]
        [Display(Name = "Representación")]
        Representacion,
        //[EnumMember(Value = "Modulo")]
        [Display(Name = "Modulo")]
        Modulo
    }

    public enum Region
    {
        //[EnumMember(Value = "Centro")]
        [Display(Name = "Centro")]
        Centro,
        //[EnumMember(Value ="Sur")]
        [Display(Name = "Sur")]
        Sur,
        //[EnumMember(Value = "Norte")]
        [Display(Name = "Norte")]
        Norte,
        //[EnumMember(Value = "Occidente")]
        [Display(Name = "Occidente")]
        Occidente,
    }
}
