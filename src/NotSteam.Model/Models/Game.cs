using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using NotSteam.Core.Models.Attributes;

namespace NotSteam.Core.Models
{
    public class Game : BaseEntity
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
        virtual public Company Company { get; set; }

        virtual public ICollection<GameTag> GameTags { get; set; }
        virtual public ICollection<Library> Libraries { get; set; }
        virtual public ICollection<Purchase> Purchases { get; set; }
        virtual public ICollection<Review> Reviews { get; set; }
    }
}

