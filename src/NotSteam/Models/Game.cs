using Newtonsoft.Json;
using NotSteam.Models.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotSteam.Models
{
    public class Game : BaseModel
    {
        [DataType(DataType.Text)]
        [CustomMaxStringLength(250)]
        [CustomRequired]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        [CustomMaxStringLength(1500)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [CustomDateRange]
        [CustomRequired]
        public DateTime ReleaseDate { get; set; } = DateTime.UtcNow;

        [Column(TypeName = "decimal(19,4)")]
        [DataType(DataType.Currency)]
        [CustomRange(0.0, 99.99)]
        [CustomRequired]
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

