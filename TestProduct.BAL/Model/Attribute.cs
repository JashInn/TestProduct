using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProduct.BAL.Model
{
    public class Attribute
    {
        public int Id { get; set; }
        [Display(Name="Attribute")]
        public string AttributeName { get; set; }
    }
}
