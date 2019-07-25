using Newtonsoft.Json;
using NotSteam.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotSteam.Models
{
    public class Purchase : IBaseDateable
    {
        public int UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; }

        public int GameId { get; set; }

        [JsonIgnore]
        public Game Game { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} is required!")]
        [CustomDateRange]
        public DateTime DateOfPurchase { get; set; } = DateTime.UtcNow;

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "{0} is required!")]
        [Range(0, 99.99, ErrorMessage = "{0} restricted from {1} to {2}!")]
        [Column(TypeName = "decimal(19,4)")]
        public decimal TotalPrice { get; set; }

        DateTime IBaseDateable.CreatedAt { get; set; } = DateTime.UtcNow;
        DateTime? IBaseDateable.LastModifiedAt { get; set; }
    }
}