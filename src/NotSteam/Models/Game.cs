using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotSteam.Models
{
    public class Game : BaseModel
    {
        [Required(ErrorMessage = "You must provide a {0}!")]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "You must provide a {0}!")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "You must provide a {0}!")]
        [Column(TypeName = "decimal(19,4)")]
        [Range(0.0, 99.99, ErrorMessage = "{0} must be between {1} and {2}!")]
        public decimal BasePrice { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; }
    }
}