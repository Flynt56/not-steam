using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotSteam.Models
{
    public class Purchase
    {
        public int UserId { get; set; }

        public User User { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [DataType(DataType.Date)]
        public DateTime DateOfPurchase { get; set; } = DateTime.UtcNow;

        [Required(ErrorMessage = "{0} is required!")]
        [Range(0, 99.99, ErrorMessage = "{0} restricted from {1} to {2}!")]
        [Column(TypeName = "decimal(19,4)")]
        [DataType(DataType.Currency)]
        public decimal TotalPrice { get; set; }
    }
}