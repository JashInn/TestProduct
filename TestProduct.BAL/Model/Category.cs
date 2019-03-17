using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestProduct.BAL.Model
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name ="Category Name")]
        public string Name { get; set; }
    }
}
