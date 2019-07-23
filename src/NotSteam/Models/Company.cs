using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You must provide a {0} for your company!")]
        public string Name { get; set; }
        [Url]
        public string HomepageUri { get; set; }
        public string Description { get; set; }
        [Url]
        public string LogoImageUri { get; set; }
    }
}