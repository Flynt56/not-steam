using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class Company : BaseModel
    {
        [Required(ErrorMessage = "You must provide a {0}!")]
        [StringLength(250, ErrorMessage = "{0} is limited to {1} characters!")]
        public string Name { get; set; }

        [Url(ErrorMessage = "Input must be a valid URL!")]
        public string HomepageUri { get; set; }

        public string Description { get; set; }

        [Url(ErrorMessage = "Input must be a valid URL!")]
        public string LogoImageUri { get; set; }
    }
}