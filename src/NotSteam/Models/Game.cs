using Newtonsoft.Json;
using NotSteam.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotSteam.Models
{
    public class Game : BaseModel
    {
        [DataType(DataType.Text)]
        [StringLength(250, ErrorMessage = "{0} is limited to {1} characters!")]
        [Required(ErrorMessage = "{0} is required!")]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(1500, ErrorMessage = "{0} is limited to {1} characters!")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [CustomDateRange]
        [Required(ErrorMessage = "{0} is required!")]
        public DateTime ReleaseDate { get; set; } = DateTime.UtcNow;

        [Column(TypeName = "decimal(19,4)")]
        [DataType(DataType.Currency)]
        [Range(0.0, 99.99, ErrorMessage = "{0} restricted from {1} to {2}!")]
        [Required(ErrorMessage = "{0} is required!")]
        public decimal BasePrice { get; set; }

        public int CompanyId { get; set; }

        [JsonIgnore]
        public Company Company { get; set; }

        public ICollection<GameTag> GameTags { get; set; }
        public ICollection<Library> Libraries { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}

