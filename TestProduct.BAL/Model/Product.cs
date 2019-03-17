using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProduct.BAL.Model
{
    public class Product
    {

        public int Id { get; set; }

        [Display(Name="Product Name")]
        public string Name { get; set; }

        public int? CategoryId { get; set; }

        [Display(Name="Description")]
        public string Description { get; set; }

        [Display(Name="Category Name")]
        public Category Category { get; set; }

    }
}
