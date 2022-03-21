namespace HepsiBurada.Domain
{
    public class ProductRequestDto : BaseClass
    {
        public string ProductCode { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
    }
}