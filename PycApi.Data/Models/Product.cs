namespace PycApi.Data
{
    public class Product //burada önce datalarımızı tanımlıyoruz.
    {
        public virtual long ProductId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string ProductDescription { get; set; }
        public virtual string ProductColour { get; set; }
        public virtual string ProductBrand { get; set; }
        public virtual long ProductPrice { get; set; }
        public virtual long CategoryId { get; set; }

    }
}
