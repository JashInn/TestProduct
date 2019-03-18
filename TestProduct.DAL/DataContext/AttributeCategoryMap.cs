namespace TestProduct.DAL.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttributeCategoryMap")]
    public partial class AttributeCategoryMap
    {
        public int Id { get; set; }

        public int? AttributeId { get; set; }

        public int? CategoryId { get; set; }

        public virtual Attribute Attribute { get; set; }

        public virtual Category Category { get; set; }
    }
}
