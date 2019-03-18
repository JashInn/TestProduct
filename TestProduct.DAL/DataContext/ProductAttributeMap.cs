namespace TestProduct.DAL.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductAttributeMap")]
    public partial class ProductAttributeMap
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }

        public int? AttributeId { get; set; }

        [StringLength(200)]
        public string Value { get; set; }

        public virtual Attribute Attribute { get; set; }

        public virtual Product Product { get; set; }
    }
}
