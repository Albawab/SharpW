using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CustomComponent.Data
{
    public class CustomModel
    {
        [Required(ErrorMessage = "Value Required")]
        public string Value { get; set; }
    }
}
