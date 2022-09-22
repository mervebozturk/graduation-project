using System.ComponentModel.DataAnnotations;

namespace PycApi.Dto
{
    public class ProductDto
    {
        [Required]
        public long productid { get; set; }

        [Required]
        [MaxLength(100)]
        public string productname { get; set; }

        [Required]
        [MaxLength(500)]
        public string productdescription { get; set; }

        [Required]
        public string productcolour { get; set; }

        [Required]
        public string productbrand { get; set; }

        [Required]
        public long productprice { get; set; }

        [Required]
        public long categoryid { get; set; }



    }
}
