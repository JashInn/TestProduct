namespace TestProduct.BAL.Model
{
    public class ProductAttributeMap
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }

        public int? AttributeId { get; set; }

        public string Value { get; set; }

        public Attribute Attribute { get; set; }

        public Product Product { get; set; }
    }
}
