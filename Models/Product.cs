using System.ComponentModel.DataAnnotations;

namespace TPUSJ.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="This field is mandatory!!!!!!!!!!!!!!!!!!!!!!!!!!!!")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set;}

    }
}
