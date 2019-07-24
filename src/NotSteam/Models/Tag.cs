using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class Tag
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must specify a {0}!")]
        [StringLength(48, ErrorMessage = "The maximum allowed amount of characters is {1}!")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}