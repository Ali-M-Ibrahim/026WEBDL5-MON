using System.ComponentModel.DataAnnotations;

namespace TPUSJ.Models
{
    public class Blog
    {
       
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Content { get; set; }
    }
}
