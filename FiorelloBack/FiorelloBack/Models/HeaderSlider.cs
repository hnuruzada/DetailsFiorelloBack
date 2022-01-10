using System.ComponentModel.DataAnnotations;

namespace FiorelloBack.Models
{
    public class HeaderSlider
    {
        public int Id { get; set; }
        [StringLength(maximumLength:100)]
        public string Title { get; set; }
        [StringLength(maximumLength: 250)]
        public string Info { get; set; }
        [StringLength(maximumLength: 70)]
        public string Signature { get; set; }
        [StringLength(maximumLength: 70)]
        public string Image { get; set; }
        public int Order { get; set; }
    }
}
