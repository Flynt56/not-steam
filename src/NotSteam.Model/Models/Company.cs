using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NotSteam.Model.Attributes;

namespace NotSteam.Model.Models
{
    public class Company : BaseEntity
    {
        [DataType(DataType.Text)]
        [CustomRequired]
        [CustomMaxStringLength(64)]
        public string Name { get; set; }

        [Url(ErrorMessage = "\"{0}\" mora biti ispravan URL!")]
        public string HomepageUri { get; set; }

        [DataType(DataType.MultilineText)]
        [CustomMaxStringLength(1500)]
        public string Description { get; set; }

        [DataType(DataType.ImageUrl)]
        [Url(ErrorMessage = "\"{0}\" mora biti ispravan URL!")]
        public string LogoImageUri { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
