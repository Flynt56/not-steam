using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class Tag : BaseModel
    {
        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(48, ErrorMessage = "{0} restricted to {1} characters!")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [StringLength(250, ErrorMessage = "{0} restricted to {1} characters!")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public ICollection<GameTag> GameTags { get; set; }
    }
}