using System.ComponentModel.DataAnnotations;

namespace PycApi.Dto
{
    public class CategoryDto
    {
        [Required]
        public long categoryid { get; set; }

        [Required]
        public string categoryname { get; set; }


    }
}
