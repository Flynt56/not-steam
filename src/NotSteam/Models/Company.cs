using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class Company : BaseModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(64, ErrorMessage = "{0} is limited to {1} characters!")]
        public string Name { get; set; }

        [Url(ErrorMessage = "{0} must be a valid URL!")]
        public string HomepageUri { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(1500, ErrorMessage = "{0} is limited to {1} characters!")]
        public string Description { get; set; }

        [DataType(DataType.ImageUrl)]
        [Url(ErrorMessage = "{0} must be a valid URL!")]
        public string LogoImageUri { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
