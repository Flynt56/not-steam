using Newtonsoft.Json;
using NotSteam.Core.Models.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotSteam.Core.Models
{
    public class Purchase : BaseModel
    {
        public int UserId { get; set; }

        public int GameId { get; set; }

        [DataType(DataType.Date)]
        [CustomRequired]
        [CustomDateRange]
        public DateTime DateOfPurchase { get; set; } = DateTime.UtcNow;

        [DataType(DataType.Currency)]
        [CustomRequired]
        [CustomRange(0.0, 99.99)]
        [Column(TypeName = "decimal(19,4)")]
        public decimal TotalPrice { get; set; }

        [JsonIgnore]
        virtual public User User { get; set; }
        [JsonIgnore]
        virtual public Game Game { get; set; }
    }
}

