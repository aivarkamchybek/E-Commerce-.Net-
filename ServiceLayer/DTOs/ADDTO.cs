namespace ServiceLayer.DTOs
{
    public class ADDTO
    {
        public int DetailID { get; set; }
        public int AttributeID { get; set; }
        public int ProductID { get; set; }
        public string Details { get; set; }
        public ProductDTO Product { get; set; }
        public AttributeDTO Attribute { get; set; }
    }
}